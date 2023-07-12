using UnityEngine;

public class CloneSample : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _parent;

    private void Start()
    {
        // 1個だけ生成する
        //Instantiate(_prefab, _parent);

        // 3個生成する
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_prefab, _parent);
        }
    }
}
