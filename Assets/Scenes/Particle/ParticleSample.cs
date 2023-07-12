using UnityEngine;

public class ParticleSample : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystem;
    
    void Start()
    {
        // パーティクルを真ん中に表示する
        _particleSystem.transform.position = Vector3.zero;
    }
}
