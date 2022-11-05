using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1 : BaseScene
{
    [SerializeField]
    Transform SpawnPoint1;
    [SerializeField]
    Transform SpawnPoint2;

    Dictionary<int, Define.Lain> spawnPoint;

    override protected void Init()
    {
        base.Init();

        SceneType = Define.Scene.Stage1;

        GameManager.UI.ShowSceneUI<UI_Game>();

        BindSpawnPoint();

        StartCoroutine(Spawn());
    }

    void BindSpawnPoint()
    {
        spawnPoint = new Dictionary<int, Define.Lain>()
        {
            { 1, Define.Lain.First },
            { 2, Define.Lain.Seceond },
            { 3, Define.Lain.None },
            { 4, Define.Lain.None },
            { 5, Define.Lain.None },
            { 6, Define.Lain.None },
            { 7, Define.Lain.None },
            { 8, Define.Lain.None },
            { 9, Define.Lain.None },
            { 10, Define.Lain.None },
            { 11, Define.Lain.None },
            { 12, Define.Lain.Seceond },
            { 13, Define.Lain.None },
            { 14, Define.Lain.None },
            { 15, Define.Lain.None },
            { 16, Define.Lain.None },
            { 17, Define.Lain.None },
            { 18, Define.Lain.First },
            { 19, Define.Lain.First },
            { 20, Define.Lain.None },
            { 21, Define.Lain.None },
            { 22, Define.Lain.None },
            { 23, Define.Lain.None },
            { 24, Define.Lain.Seceond },
            { 25, Define.Lain.None },
            { 26, Define.Lain.None },
            { 27, Define.Lain.First },
            { 28, Define.Lain.Seceond },
            { 29, Define.Lain.None },
            { 30, Define.Lain.First },
        };
    }

    void BindInformation()
    {
        spawnPoint = new Dictionary<int, Define.Lain>()
        {
            { 1, Define.Lain.First },
            { 2, Define.Lain.Seceond },
            { 3, Define.Lain.None },
            { 4, Define.Lain.None },
            { 5, Define.Lain.None },
            { 6, Define.Lain.None },
            { 7, Define.Lain.None },
            { 8, Define.Lain.None },
            { 9, Define.Lain.None },
            { 10, Define.Lain.None },
            { 11, Define.Lain.None },
            { 12, Define.Lain.Seceond },
            { 13, Define.Lain.None },
            { 14, Define.Lain.None },
            { 15, Define.Lain.None },
            { 16, Define.Lain.None },
            { 17, Define.Lain.None },
            { 18, Define.Lain.First },
            { 19, Define.Lain.First },
            { 20, Define.Lain.None },
            { 21, Define.Lain.None },
            { 22, Define.Lain.None },
            { 23, Define.Lain.None },
            { 24, Define.Lain.Seceond },
            { 25, Define.Lain.None },
            { 26, Define.Lain.None },
            { 27, Define.Lain.First },
            { 28, Define.Lain.Seceond },
            { 29, Define.Lain.None },
            { 30, Define.Lain.First },
        };
    }

    IEnumerator Spawn()
    {
        for (int i = 1; i <= spawnPoint.Count; i++)
        {
            Debug.Log(spawnPoint[i]);
            switch (spawnPoint[i])
            {
                case Define.Lain.None:
                    break;
                case Define.Lain.First:
                    {
                        GameObject go = GameManager.Resource.Instantiate("Object/Car");
                        go.transform.position = SpawnPoint1.position;
                    }
                    break;
                case Define.Lain.Seceond:
                    {
                        GameObject go = GameManager.Resource.Instantiate("Object/Car");
                        go.transform.position = SpawnPoint2.position;
                    }
                    break;
            }

            yield return new WaitForSeconds(1.5f);
        }
    }
}
