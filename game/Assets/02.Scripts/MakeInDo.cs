using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeInDo : MonoBehaviour {
    int Go = 2;

    public GameObject obj;
	void Start () {
        InvokeRepeating("IndoMaker", 1, 2);   // 딜레이 IndoMaker를 1초후에 시작해서 2초에 한번씩 실행
    }
	
	
	void IndoMaker () {
        Instantiate(obj, new Vector3(0, 0, Go), Quaternion.identity);           // obj에 프리팹 넣고 z값에 따라 프리팹 생성
        Go += 2;            // z좌표 2씩 증가
    }
}
