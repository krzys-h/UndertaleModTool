// By Grossley
ScriptMessage("Script start");
ScriptMessage("Checking normal test script within this script");
bool x = LintUMTScript(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "DemoScripts", "ScriptTestSuccess.txt"));
ScriptMessage("Test script compiles? Status: " + x.ToString());
ScriptMessage("Checking broken test script within this script");
x = LintUMTScript(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "DemoScripts", "ScriptTestFail.txt"));
ScriptMessage("Test script compiles? Status: " + x.ToString());
ScriptMessage("Script end");
