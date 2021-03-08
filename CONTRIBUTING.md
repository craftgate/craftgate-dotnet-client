# Contributing to Craftgate .NET Client
As an open-source project, anyone can contribute to the development of `craftgate-dotnet-client`. If you decide to do so, please be aware of the guidelines outlined below.

## Prerequisites
`craftgate-dotnet-client` is written in .NET, in order to contribute to the project, some familiarity with .NET knowledge is required. Please see the [requirements](/#requirements)

## Package Structure
The project has a straightforward package structure; the source files are located under the [Craftgate](Craftgate), sample integrations are located under [Samples](Samples), and tests are located under [Test](Test).

As outlined in the [README](./README.md), the bulk of the project is split into the following categories:

- Adapters: Located under the [Craftgate/Adapter](Craftgate/Adapter) package, these are classes that are responsible for managing a certain domain
- Enumerations and Domain Objects: Located under [Craftgate/Model](Craftgate/Model), these are enumerations, constants and domain object models that can be used by request and response.
- HttpClient: Located under [Craftgate/Net](Craftgate/Net), these are utility functions to handle the traffic between backend and client.

## Tests and Coverage
As a payment systems client, it's important to have tests covering critical parts. In addition to tests that test crucial parts of the libraries and utilities, all samples are provided as runnable.
It is strongly advised for all contributors to run all samples against the changes introduced in the pull request. If there are no corresponding tests against the changes introduced, owner of the pull request is responsible for adding any relevant tests or samples.
