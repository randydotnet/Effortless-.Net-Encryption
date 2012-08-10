// <copyright file="PexAssemblyInfo.cs" company="Simon Hughes">Copyright © Simon Hughes 2008</copyright>

using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Moles;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;
using System.Text;
using System;

// Microsoft.Pex.Framework.Settings

[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation

[assembly: PexAssemblyUnderTest("Effortless.Net.Encryption")]

// Microsoft.Pex.Framework.Coverage

[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Effortless.Net.Encryption.Tests")]

// Microsoft.Pex.Framework.Moles

[assembly: PexAssumeContractEnsuresFailureAtBehavedSurface]
[assembly: PexChooseAsBehavedCurrentBehavior]

// Microsoft.Pex.Framework.Validation

[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexInstrumentType(typeof (EncoderReplacementFallback))]
[assembly: PexInstrumentType(typeof (DecoderReplacementFallback))]
[assembly: PexInstrumentType(typeof (BitConverter))]
[assembly: PexInstrumentType(typeof (EncoderFallback))]
[assembly: PexInstrumentType(typeof (DecoderFallback))]
[assembly: PexInstrumentType(typeof (UnicodeEncoding))]