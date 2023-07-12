using UnityEngine;

public class ParticleSample : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystem;
    
    void Start()
    {
        // パーティクルを真ん中に表示する
        _particleSystem.transform.position = Vector3.zero;
    }

    #if UNITY_EDITOR
    // ContextMenuを使ってメニューを追加する
    [ContextMenu("Play")]
    void Play()
    {
        _particleSystem.Play();
    }

    [ContextMenu("Stop")]
    void Stop()
    {
        _particleSystem.Stop();
    }
    #endif
}