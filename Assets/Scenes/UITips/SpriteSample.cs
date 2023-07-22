using UnityEngine;

public class SpriteSample : MonoBehaviour
{
    [SerializeField] SpriteRenderer _spriteRenderer;
    
    void Start()
    {
        _spriteRenderer.color = Color.gray;
    }
}
