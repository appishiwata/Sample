using UniRx;
using UnityEngine;

public class VrmAnimSample : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] SkinnedMeshRenderer _skinnedMeshRenderer;

    void Start()
    {
        _animator.SetInteger("animBaseInt", 1);
        _skinnedMeshRenderer.SetBlendShapeWeight(0, 20f);

        // BlendShapeの一覧を表示
        for (int i = 0; i < _skinnedMeshRenderer.sharedMesh.blendShapeCount; i++)
        {
            float weight = _skinnedMeshRenderer.GetBlendShapeWeight(i);
            Debug.Log($"BlendShape index: {i}, Weight: {weight}");
            //_skinnedMeshRenderer.SetBlendShapeWeight(i, 100f);
        }

        // UniRXでスペースキーを押したらアニメーションを変更する
        Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.Space))
            .Subscribe(_ =>
            {
                _animator.Play("Layer_look_away", 1, 0.0f);
            });
        
        // UniRXでEnterキーを押したらBlendShapeを変更する
        Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.Return))
            .Subscribe(_ =>
            {
                _skinnedMeshRenderer.SetBlendShapeWeight(145, 100f);
                _skinnedMeshRenderer.SetBlendShapeWeight(148, 100f); // 肘縮小
                _skinnedMeshRenderer.SetBlendShapeWeight(149, 100f);
            });
    }
    
    public float speed = 10.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
