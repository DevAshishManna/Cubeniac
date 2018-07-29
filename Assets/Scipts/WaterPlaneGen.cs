using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPlaneGen : MonoBehaviour {
  public float size = 1;
  public int gridSize = 16;

  private MeshFilter filter;

  private void Start () {
    filter = GetComponent<MeshFilter>();
    filter.mesh = GenerateMesh();
  }

  private Mesh GenerateMesh(){
    Mesh m = new Mesh();

    var vertices = new List<Vector3>();
    var normals = new List<Vector3>();
    var uvs = new List<Vector3>();

    for(int x=0;x<gridSize+1;x++){
      for(int y=0;y<gridSize+1;y++){
                vertices.Add(new Vector3(-size * 0.5f + size * (x / ((float)gridSize)), 0, -size * 0.5f + size*(y / ((float)gridSize))));
        normals.Add(Vector3.up);
        uvs.Add(new Vector2(x/(float)gridSize,(float)gridSize));
      }
    }

    var triangles = new List<int>();
    var vertCount = gridSize +1;
    for (int i =0; i<vertCount*vertCount-vertCount; i++) {
      if((i+1)%vertCount==0){
        continue;
      }
            triangles.AddRange(new List<int>(){
        i+1+vertCount, i+vertCount,i,
        i,i+1,i+vertCount+1
        });
    }

    m.SetVertices(vertices);
    m.SetNormals(normals);
    m.SetUVs(0,uvs);
    m.SetTriangles(triangles,0);

        return m;
    }
}
