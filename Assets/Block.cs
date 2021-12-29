using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [System.Serializable]
    public enum BlockSide { BOTTOM, TOP, LEFT, RIGHT, FRONT, BACK };
    public BlockSide side = BlockSide.FRONT;
    
    // Start is called before the first frame update
    void Start()
    {
        MeshFilter mf = this.gameObject.AddComponent<MeshFilter>();
        MeshRenderer mr = this.gameObject.AddComponent<MeshRenderer>();

        Quad q = new Quad();
        mf.mesh = q.Build(side);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
