#!/usr/bin/env bash
# Validates the version requested from the release workflow and writes VERSION and TAG to GITHUB_ENV
# (and as "version" and "tag" step outputs).
# "1.0.84" and "v1.0.84" are both accepted; the tag is created as "<tag-prefix>1.0.84".
# Fails if the version is not X.Y.Z, is already tagged (with or without "v") or is not above the latest release.
set -euo pipefail
input="${1:?usage: prepare-release.sh <version> [tag-prefix]}"
prefix="${2:-}"
version="${input#v}"

if [[ ! "$version" =~ ^[0-9]+\.[0-9]+\.[0-9]+$ ]]; then
  echo "::error::Version must be in the form X.Y.Z, got '$input'"
  exit 1
fi

for existing in "$version" "v$version"; do
  if git rev-parse -q --verify "refs/tags/$existing" >/dev/null; then
    echo "::error::Version $version is already released as tag '$existing'"
    exit 1
  fi
done

latest="$(git tag --list | sed -nE 's/^v?([0-9]+\.[0-9]+\.[0-9]+)$/\1/p' | sort -V | tail -n 1)"
if [[ -n "$latest" && "$(printf '%s\n%s\n' "$latest" "$version" | sort -V | tail -n 1)" != "$version" ]]; then
  echo "::error::Version $version must be greater than the latest release $latest"
  exit 1
fi

echo "Releasing $version as tag $prefix$version (latest release: ${latest:-none})"
echo "VERSION=$version" >> "$GITHUB_ENV"
echo "TAG=$prefix$version" >> "$GITHUB_ENV"
if [[ -n "${GITHUB_OUTPUT:-}" ]]; then
  printf 'version=%s\ntag=%s\n' "$version" "$prefix$version" >> "$GITHUB_OUTPUT"
fi
