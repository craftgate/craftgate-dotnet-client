# NOTICE

**Craftgate .NET Client** (`Craftgate`)

Copyright (c) 2021 Craftgate

This product is developed and maintained by Craftgate (https://craftgate.io).

This software is licensed under the terms of the Apache License, Version 2.0
(the "License"); you may not use this software except in compliance with the
License. A full copy of the License is included in the [`LICENSE`](./LICENSE)
file distributed with this software.

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.

---

## Third-Party Software

This product depends on the third-party software components listed below. Each
component is the property of its respective owners and is governed by its own
license. The Craftgate .NET Client does not modify these components; they are
referenced as external dependencies and resolved via NuGet.

License texts are available at the URLs provided. Inclusion of a component in
this list does not imply endorsement by its authors.

### Runtime Dependencies

These components are required at runtime and are resolved transitively when the
Craftgate .NET Client package is installed.

#### Json.NET (Newtonsoft.Json)

- **Package:** `Newtonsoft.Json@13.0.1`
- **Copyright:** Copyright (c) 2007 James Newton-King
- **License:** MIT License
- **Homepage:** https://www.newtonsoft.com/json
- **License text:** https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md

The following Microsoft .NET platform packages are referenced only when
targeting `netstandard1.3`:

#### System.Security.Cryptography.Algorithms

- **Package:** `System.Security.Cryptography.Algorithms@4.3.0`
- **Copyright:** Copyright (c) .NET Foundation and Contributors
- **License:** MIT License
- **Homepage:** https://dot.net/
- **License text:** https://github.com/dotnet/runtime/blob/main/LICENSE.TXT

#### System.Reflection.TypeExtensions

- **Package:** `System.Reflection.TypeExtensions@4.7.0`
- **Copyright:** Copyright (c) .NET Foundation and Contributors
- **License:** MIT License
- **Homepage:** https://dot.net/
- **License text:** https://github.com/dotnet/runtime/blob/main/LICENSE.TXT

When targeting `net45`, the client additionally references `System.Net.Http`,
which is provided as part of the Microsoft .NET Framework and is governed by
the .NET Framework license.

### Test-Only Dependencies

These components are used by the test project (`Test/`) only. They are **not**
required at runtime and are **not** included in the distributed NuGet package.

- **Microsoft.NET.Test.Sdk** `15.6.2` — MIT License
  (https://github.com/microsoft/vstest)
- **MSTest.TestAdapter** `1.2.0` — MIT License
  (https://github.com/microsoft/testfx)
- **MSTest.TestFramework** `1.2.0` — MIT License
  (https://github.com/microsoft/testfx)
- **NUnit** `3.10.1` — MIT License
  (https://github.com/nunit/nunit)
- **NUnit3TestAdapter** `3.10.0` — MIT License
  (https://github.com/nunit/nunit3-vs-adapter)

---

## Attribution

If you redistribute this software, in source or binary form, you must retain
the copyright notice and license text of the Craftgate .NET Client, together
with the attributions for the third-party components listed above, in
accordance with their respective license terms.

For questions regarding licensing or attribution, contact info@craftgate.io.
