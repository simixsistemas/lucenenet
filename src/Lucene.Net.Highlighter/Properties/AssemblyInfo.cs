/*
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 *
*/

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Lucene.Net.Highlighter")]
[assembly: AssemblyDescription(
    "Highlights search keywords in results " +
    "of the Lucene.Net full-text search engine library from The Apache Software Foundation.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyDefaultAlias("Lucene.Net.Highlighter")]
[assembly: AssemblyCulture("")]

[assembly: CLSCompliant(true)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e9e769ea-8504-44bc-8dc9-ccf958765f8f")]

[assembly: InternalsVisibleTo("Lucene.Net.Icu")]
// for testing
[assembly: InternalsVisibleTo("Lucene.Net.Tests.Highlighter")]
[assembly: InternalsVisibleTo("Lucene.Net.Tests.Icu")]

// NOTE: Version information is in CommonAssemblyInfo.cs
