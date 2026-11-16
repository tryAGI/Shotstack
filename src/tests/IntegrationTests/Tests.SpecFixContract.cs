namespace Shotstack.IntegrationTests;

/// <summary>
/// What generate.sh does to the spec, checked without an API key.
///
/// The upstream spec is split across files; generate.sh bundles it with redocly and converts the
/// auth. Without the bundle the referenced schemas are missing.
///
/// This SDK passes no `--security-scheme`, so there is no credential to assert; what can be checked
/// is that the fix still produces the surface it exists to produce. Every other test here needs an
/// API key and reports inconclusive without one, so the suite printed `Skipped!` and exited 0 —
/// which reads exactly like a passing run.
/// </summary>
[TestClass]
public class SpecFixContractTests
{
    [TestMethod]
    public void TheSurfaceTheSpecFixProducesIsStillThere()
    {
        Assert.IsNotNull(
            typeof(global::Shotstack.ShotstackClient).Assembly.GetType("Shotstack.IngestClient", throwOnError: false),
            "Shotstack.IngestClient is gone. It is generated from the document generate.sh produces; " +
            "if a spec refresh removed it, look at the fix rather than at this test.");
    }

    [TestMethod]
    public void TheDefaultBaseUrlIsTheOneTheSpecDeclares()
    {
        Assert.AreEqual("https://api.shotstack.io/", global::Shotstack.ShotstackClient.DefaultBaseUrl);
    }
}
