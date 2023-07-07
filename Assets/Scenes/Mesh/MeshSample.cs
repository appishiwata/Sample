using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshSample : MonoBehaviour
{
    [SerializeField] GameObject _sphere;

    [SerializeField] Mesh _mesh;

    void Start()
    {
        // _sphereのMeshを取得
        var mesh = _sphere.GetComponent<MeshFilter>().mesh;
        // _sphereのMeshの頂点を取得
        var vertices = mesh.vertices;
        // _sphereのMeshの頂点を変更
        vertices[0] = new Vector3(1, 0, 0);
        // _sphereのMeshの頂点を設定
        mesh.vertices = vertices;
        // _sphereのMeshの頂点を反映
        mesh.RecalculateBounds();


        // submeshを取得
        var subMesh = mesh.subMeshCount;
       
        // メッシュをオブジェクトに設定
        _sphere.GetComponent<MeshFilter>().mesh = _mesh;
    }
}
