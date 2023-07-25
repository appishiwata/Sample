using UnityEngine;

public class RestartSample : MonoBehaviour
{
    // これはUnityエディター上では動作しない
    private void OnApplicationPause(bool pauseStatus) {
        if (pauseStatus) {
            Debug.Log($"アプリが一時停止(バックグラウンドに行った)");
        }
        else {
            Debug.Log($"アプリが再開(バックグラウンドから戻った)");
        }
    }
    
    // これはUnityエディター上では動作する
    private void OnApplicationFocus(bool hasFocus) {
        if (hasFocus) {
            Debug.Log($"アプリが選択された(バックグラウンドから戻った)");
        }
        else {
            Debug.Log($"アプリが選択されなくなった(バックグラウンドに行った)");
        }
    }
}
