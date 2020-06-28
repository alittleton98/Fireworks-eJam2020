using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceMember : MonoBehaviour
{

    MaterialPropertyBlock block;
    MaterialPropertyBlock iconBlock;
    public Mesh mesh;
    public Material material;
    public Material iconMaterial;

    int colorID, progressID, iconID;

    public Texture tex;

    // Start is called before the first frame update
    void Start()
    {
        //MeshRenderer renderer = GetComponent<MeshRenderer>();
        block = new MaterialPropertyBlock();
        iconBlock = new MaterialPropertyBlock();
        colorID = Shader.PropertyToID("_EndColor");
        progressID = Shader.PropertyToID("_Progress");

        iconID = Shader.PropertyToID("_Icon");
    }

    // Update is called once per frame
    void Update()
    {

        Matrix4x4 matrix = gameObject.transform.localToWorldMatrix;


        //iconMatrix[0, 0] *= 0.1f;
        //iconMatrix[1, 1] *= 0.1f;
        //iconMatrix[2, 2] *= 0.1f;
        //iconMatrix[3, 3] *= 0.1f;
        // blue mesh
        block.SetColor(colorID, Color.red);
        block.SetFloat(progressID, Mathf.Abs(Mathf.Sin(Time.time)));


        Graphics.DrawMesh(mesh, matrix, material, 0, null, 0, block);


        Matrix4x4 iconMatrix = matrix;

        Vector3 scale = new Vector3(0.5f, 0.5f, 0.5f);
        Matrix4x4 scaleMatrix = Matrix4x4.Scale(scale);
        iconMatrix *= scaleMatrix;

        Vector3 forward = gameObject.transform.up * 0.01f;

        iconMatrix[0, 3] += forward.x;
        iconMatrix[1, 3] += forward.y;
        iconMatrix[2, 3] += forward.z;

        iconBlock.SetTexture(iconID, tex);


        Graphics.DrawMesh(mesh, iconMatrix, iconMaterial, 0, null, 0, iconBlock);
    }
}
