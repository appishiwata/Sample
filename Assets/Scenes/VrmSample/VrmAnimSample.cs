using UnityEngine;

public class VrmAnimSample : MonoBehaviour
{
    [SerializeField] Animator _animator;
    
    void Start()
    {
        _animator.SetInteger("animBaseInt", 3);
    }
}
