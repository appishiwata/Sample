using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshSample : MonoBehaviour
{
    [SerializeField] GameObject _sphere;

    [SerializeField] Mesh _mesh;

    [SerializeField] GameObject _sampleObject;
    [SerializeField] GameObject _cube;
    [SerializeField] Material _red;
    [SerializeField] Material _blue;

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

        //createMesh();
        createMeshAndSubMesh();
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

        // 法線ベクトルの設定
        Vector3[] normals = new Vector3[4]
        {
            new Vector3(0, 0, -1),
            new Vector3(0, 0, -1),
            new Vector3(0, 0, -1),
            new Vector3(0, 0, -1)
        };

        // メッシュオブジェクトの作成
        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.normals = normals;
        mesh.name = "MeshSample";

        // ゲームオブジェクトの作成
        _sampleObject.GetComponent<MeshFilter>().mesh = mesh;


        // _cubeのMeshを取得
        var cubeMesh = _cube.GetComponent<MeshFilter>().mesh;

        // メッシュのサイズを取得
        var size = cubeMesh.bounds.size;
        // メッシュの中心座標を取得
        var center = cubeMesh.bounds.center;
        // メッシュの最小座標を取得
        var min = cubeMesh.bounds.min;
        // メッシュの最大座標を取得
        var max = cubeMesh.bounds.max;

        Debug.Log("size:" + size);
        Debug.Log("center:" + center);
        Debug.Log("min:" + min);
        Debug.Log("max:" + max);


        // メッシュの頂点座標を取得
        
    }

    void createMeshAndSubMesh()
    {
        // メッシュオブジェクトの作成
        Mesh mesh = new Mesh();

        // 頂点座標の設定
        Vector3[] vertices = new Vector3[4]
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(0, 1, 0),
            new Vector3(1, 1, 0)
        };

        // サブメッシュ1の三角形のインデックス
        int[] subMesh1Triangles = new int[3] { 0, 2, 1 };

        // サブメッシュ2の三角形のインデックス
        int[] subMesh2Triangles = new int[3] { 1, 2, 3 };

        // 頂点座標とサブメッシュごとの三角形のインデックスを設定
        mesh.vertices = vertices;
        mesh.subMeshCount = 2;
        mesh.SetTriangles(subMesh1Triangles, 0);
        mesh.SetTriangles(subMesh2Triangles, 1);

        // サブメッシュごとのマテリアルを設定
        var materials = new Material[2] { _red, _blue };
        _sampleObject.GetComponent<MeshRenderer>().materials = materials;

        // ゲームオブジェクトにメッシュを割り当てる
        _sampleObject.GetComponent<MeshFilter>().mesh = mesh;        
    }
}
