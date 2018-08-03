using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {

    float Z;

	void Update () {
        Z = GameObject.Find("Cube").transform.position.z; // 큐브의 위치를 가져옴

		if(this.transform.position.z < Z - 12) // 큐브와 멀어지면 삭제
        {
            Destroy(this.gameObject);
        }
	}
}
