#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.Reflection;

public static class ForceSolutionSync
{
    [MenuItem("Tools/�����/Visual Studio �ַ�� ���� �����")]
    public static void RegenerateSolution()
    {
        var syncVS = typeof(UnityEditor.Editor).Assembly
            .GetType("UnityEditor.SyncVS");

        var syncSolution = syncVS.GetMethod("SyncSolution", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

        if (syncSolution != null)
        {
            syncSolution.Invoke(null, null);
            Debug.Log("Visual Studio �ַ��/������Ʈ ���� ����� �Ϸ�.");
        }
        else
        {
            Debug.LogError("SyncSolution �޼��带 ã�� �� �����ϴ�.");
        }
    }
}
#endif
