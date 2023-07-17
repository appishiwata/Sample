using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplitImageSample : MonoBehaviour
{
    public Texture2D sourceTexture; 
    public GameObject imagePrefab;
    public int minSize = 32;
    public int maxSize = 128;

    [SerializeField] List<Texture2D> _splitTextures = new List<Texture2D>();

    private void Start()
    {
        SplitTextureRandomly();
        DisplayRandomTexture();
    }

    public void SplitTextureRandomly()
    {
        int x = 0;
        
        while (x < sourceTexture.width)
        {
            int y = 0;
            while (y < sourceTexture.height)
            {
                int width = Random.Range(minSize, maxSize);
                if (x + width > sourceTexture.width) width = sourceTexture.width - x;

                int height = Random.Range(minSize, maxSize);
                if (y + height > sourceTexture.height) height = sourceTexture.height - y;

                Texture2D splitTexture = new Texture2D(width, height);
                splitTexture.SetPixels(sourceTexture.GetPixels(x, y, width, height));
                splitTexture.Apply();
                _splitTextures.Add(splitTexture);
                
                y += height;
            }

            x += maxSize;
        }
    }
    
    public Transform myCanvas; // Canvas object you want to parent the images to
    
    public void DisplayRandomTexture()
    {
        // 画像プレハブへの参照を確認
        if (imagePrefab == null)
        {
            Debug.LogError("Image prefab is not assigned.");
            return;
        }
    
        // 指定のリストに存在する全ての画像に対してPrefabを生成
        foreach (var texture in _splitTextures)
        {
            // 画像プレハブから新しいインスタンスを作成し、ランダムなテクスチャを適用
            GameObject newImage = Instantiate(imagePrefab, Vector3.zero, Quaternion.identity);
            Image image = newImage.GetComponent<Image>();
            if (image != null)
            {
                image.sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
            }
    
            // ランダムな位置を設定
            Vector3 randomPosition = new Vector3(Random.Range(-200, 200), Random.Range(-200, 200), 0);
            newImage.transform.position = randomPosition;
    
            // キャンバスの子として追加
            newImage.transform.SetParent(myCanvas, false);
        }
    
    }
}