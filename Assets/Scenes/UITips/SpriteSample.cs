using DG.Tweening;
using UnityEngine;

public class SpriteSample : MonoBehaviour
{
    [SerializeField] SpriteRenderer _spriteRenderer;
    
    void Start()
    {
        _spriteRenderer.color = Color.gray;
        
        // 反転させる
        _spriteRenderer.flipX = true;
        
        // x5.5からx-5.5に移動させる
        _spriteRenderer.transform.position = new Vector3(5.5f, 0f, 0f);
        _spriteRenderer.transform.DOMoveX(-5.5f, 3f)
            .SetDelay(0.5f);
    }
}
