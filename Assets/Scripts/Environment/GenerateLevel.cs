using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] sections;
    public int zPos = 50;
    public bool creatingSection = false;
    public int secNum;

    // Update is called once per frame
    void Update()
    {
        if (!creatingSection)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    private IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(sections[secNum], new Vector3(0f, 0f, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(5);
        creatingSection = false;
    }
}
