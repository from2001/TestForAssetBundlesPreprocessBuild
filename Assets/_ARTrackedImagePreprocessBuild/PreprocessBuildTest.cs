using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PreprocessBuildTest : MonoBehaviour
{
    [MenuItem("Test/AR Tracked Image PreprocessBuild")]
    static void ExportAssetBundles()
    {
        UnityEditor.XR.ARSubsystems.ARBuildProcessor.PreprocessBuild(BuildTarget.VisionOS);
        Debug.Log("PreprocessBuild completed");
    }
}
