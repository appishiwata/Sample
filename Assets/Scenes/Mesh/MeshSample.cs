using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshSample : MonoBehaviour
{
    [SerializeField] GameObject _sphere;

    [SerializeField] Mesh _mesh;

    [SerializeField] GameObject _sampleObject;

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

        createMesh();
    }

    void createMesh()
    {
        // 頂点座標の設定
        Vector3[] vertices = new Vector3[4]
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(0, 1, 0),
            new Vector3(1, 1, 0)
        };

        // 三角形のインデックス
        int[] triangles = new int[6] { 0, 2, 1, 1, 2, 3 };

        // メッシュオブジェクトの作成
        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        // ゲームオブジェクトの作成
        _sampleObject.GetComponent<MeshFilter>().mesh = mesh;
    }
}
