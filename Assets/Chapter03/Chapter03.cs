using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter03 : MonoBehaviour
{
    [SerializeField] MeshFilter mesh;
    [SerializeField] Transform camTR;
    [SerializeField] Material hitMat;
    [SerializeField] Material nohitMat;
    public List<Vector3> vertexes;

    void Start()
    {
        vertexes.Clear();
    }

    private void OnDrawGizmos()
    {
        vertexes.Clear();
        foreach (var v in mesh.mesh.vertices)
        {
            vertexes.Add(v);
        }

        Vector3 cameraPoint = camTR.position + camTR.forward * 5f;
        Debug.DrawLine(camTR.position, camTR.position + camTR.forward * 5f, Color.gray);

        // 각 edge vector와 cameraPoint to vertex vector
        Vector3 edge1 = vertexes[1] - vertexes[0];
        Vector3 edge2 = cameraPoint - vertexes[1];
        Vector3 edge3 = vertexes[2] - vertexes[1];
        Vector3 edge4 = cameraPoint - vertexes[2];
        Vector3 edge5 = vertexes[0] - vertexes[2];
        Vector3 edge6 = cameraPoint - vertexes[0];

        // 각 정점에서의 법선벡터
        Vector3 cp1 = Vector3.Cross(edge1, edge2);
        Vector3 cp2 = Vector3.Cross(edge3, edge4);
        Vector3 cp3 = Vector3.Cross(edge5, edge6);

        // DrawLine
        Gizmos.color = Color.red;
        Gizmos.DrawLine(vertexes[0], vertexes[1]);
        Gizmos.DrawLine(vertexes[1], vertexes[2]);
        Gizmos.DrawLine(vertexes[2], vertexes[0]);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(vertexes[1], cameraPoint);
        Gizmos.DrawLine(vertexes[2], cameraPoint);
        Gizmos.DrawLine(vertexes[0], cameraPoint);
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(vertexes[0], vertexes[0] + cp1);
        Gizmos.DrawLine(vertexes[1], vertexes[1] + cp2);
        Gizmos.DrawLine(vertexes[2], vertexes[2] + cp3);

        // 삼각형 내부 hit
        if (Vector3.Dot(cp1, cp2) > 0f && Vector3.Dot(cp1, cp3) > 0f)
            mesh.gameObject.GetComponent<MeshRenderer>().material = hitMat;
        // 삼각형 외부 hit
        else
            mesh.gameObject.GetComponent<MeshRenderer>().material = nohitMat;
    }


    void Update()
    {
        vertexes.Clear();
        foreach (var v in mesh.mesh.vertices)
        {
            vertexes.Add(v);
        }

        Vector3 cameraPoint = camTR.position + camTR.forward * 5f;
        Debug.DrawLine(camTR.position, camTR.position + camTR.forward * 5f, Color.gray);

        // 각 edge vector와 cameraPoint to vertex vector
        Vector3 edge1 = vertexes[1] - vertexes[0];
        Vector3 edge2 = cameraPoint - vertexes[1];
        Vector3 edge3 = vertexes[2] - vertexes[1];
        Vector3 edge4 = cameraPoint - vertexes[2];
        Vector3 edge5 = vertexes[0] - vertexes[2];
        Vector3 edge6 = cameraPoint - vertexes[0];

        // 각 정점에서의 법선벡터
        Vector3 cp1 = Vector3.Cross(edge1, edge2);
        Vector3 cp2 = Vector3.Cross(edge3, edge4);
        Vector3 cp3 = Vector3.Cross(edge5, edge6);

        // DrawLine
        Gizmos.color = Color.red;
        Gizmos.DrawLine(vertexes[0], vertexes[1]);
        Gizmos.DrawLine(vertexes[1], vertexes[2]);
        Gizmos.DrawLine(vertexes[2], vertexes[0]);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(vertexes[1], cameraPoint);
        Gizmos.DrawLine(vertexes[2], cameraPoint);
        Gizmos.DrawLine(vertexes[0], cameraPoint);
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(vertexes[0], vertexes[0] + cp1);
        Gizmos.DrawLine(vertexes[1], vertexes[1] + cp2);
        Gizmos.DrawLine(vertexes[2], vertexes[2] + cp3);

        // 삼각형 내부 hit
        if(Vector3.Dot(cp1,cp2) > 0f && Vector3.Dot(cp1, cp3) > 0f) 
            mesh.gameObject.GetComponent<MeshRenderer>().material = hitMat;
        // 삼각형 외부 hit
        else
            mesh.gameObject.GetComponent<MeshRenderer>().material = nohitMat;
    }
}
