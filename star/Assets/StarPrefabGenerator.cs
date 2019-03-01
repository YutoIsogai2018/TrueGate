using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPrefabGenerator : MonoBehaviour
{
    public GameObject m_prefab;

    // Use this for initialization
    void Start ()
    {
        // 星の生成
        for (int i = 1; i < 50; i++)
        {
            int x = Random.Range(-50, 50);
            int y = Random.Range(-5, 90);
            Instantiate(m_prefab, new Vector3(x, y, 0), Quaternion.identity);
            m_prefab.name = "" + i;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
