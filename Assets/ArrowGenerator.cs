using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    [SerializeField] GameObject arrowPrefab; //public->에디터 연동
    public float span = 1.0f;
    float delta =0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go= Instantiate(arrowPrefab);
            int px = Random.Range(-11, 12);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
