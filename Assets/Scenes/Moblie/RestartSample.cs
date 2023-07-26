using UnityEngine;

public class RestartSample : MonoBehaviour
{
    //バックグラウンドに行っているか
    private bool _isBackground;
  
    private void OnApplicationPause(bool pauseStatus) {
        ChangeBackgroundStatus(pauseStatus);
    }

    private void OnApplicationFocus(bool hasFocus) {
        ChangeBackgroundStatus(!hasFocus);
    }

    //アプリがバックグラウンドにいるかのステータスを変更
    private void ChangeBackgroundStatus(bool isBackground) {
        if (isBackground == _isBackground) {
            return;
        }

        if (isBackground) {
            Debug.Log($"アプリがバックグラウンドへ");
        }
        else{
            Debug.Log($"アプリがバックグラウンドから復帰");
        }

        _isBackground = isBackground;
    }
}
