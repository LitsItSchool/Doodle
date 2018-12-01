using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class LevelGenerator : MonoBehaviour
{

    // Use this for initialization
    public GameObject prefab;

    private List<GameObject> _levelParts;
    public int partCounts;
    public float width;
    public float minHeightStep;
    public float maxHeightStep;
    private float currentHeight;
    void Start()
    {
        Init();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Init()
    {
        _levelParts = new List<GameObject>();

        for (int i = 0; i < partCounts; i++)
        {
            _levelParts.Add(Instantiate(prefab));
            ResetPosition(_levelParts.LastOrDefault());
        }
       // StartGenerate();
    }

    public void StartGenerate()
    {
        for (int i = 0; i < _levelParts.Count; i++)
        {
            _levelParts[i].transform.position = new Vector3(Random.Range(-width, width), currentHeight + Random.Range(minHeightStep, maxHeightStep),0);
        }
        currentHeight = _levelParts.LastOrDefault().transform.position.y;
    }

    public void ResetPosition(GameObject objectToReset)
    {
        objectToReset.transform.position = new Vector3(Random.Range(-width, width), currentHeight + Random.Range(minHeightStep, maxHeightStep), 0);
        currentHeight = objectToReset.transform.position.y;
    }

}
