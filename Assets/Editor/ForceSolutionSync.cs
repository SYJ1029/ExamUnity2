#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.Reflection;

public static class ForceSolutionSync
{
    [MenuItem("Tools/재생성/Visual Studio 솔루션 강제 재생성")]
    public static void RegenerateSolution()
    {
        var syncVS = typeof(UnityEditor.Editor).Assembly
            .GetType("UnityEditor.SyncVS");

        var syncSolution = syncVS.GetMethod("SyncSolution", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

        if (syncSolution != null)
        {
            syncSolution.Invoke(null, null);
            Debug.Log("Visual Studio 솔루션/프로젝트 파일 재생성 완료.");
        }
        else
        {
            Debug.LogError("SyncSolution 메서드를 찾을 수 없습니다.");
        }
    }
}
#endif
