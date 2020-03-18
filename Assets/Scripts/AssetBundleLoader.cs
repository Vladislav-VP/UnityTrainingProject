using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class AssetBundleLoader : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadAssetBundle());
    }

    private IEnumerator LoadAssetBundle()
    {
        string bundlePath = Path.Combine(Application.streamingAssetsPath, "simplebundle");

        UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle(bundlePath);
        request.SendWebRequest();
        while (!request.isDone)
        {
            yield return null;
        }

        AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(request);
        GameObject cube = bundle.LoadAsset<GameObject>("Cube");
        Instantiate(cube, transform);

        yield return null;
    }
}
