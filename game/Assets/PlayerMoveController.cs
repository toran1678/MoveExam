using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour {

    public float speed;

    private CharacterController controller;
    private Vector3 MoveDir; // 움직임 값

	void Start () {
        speed = 6.0f;

        MoveDir = Vector3.zero; // 값 초기화
        controller = GetComponent<CharacterController>(); // 캐릭터 컨트롤러를 이용한 움직임 할꺼임
	}

    void Update () {
		if (this.transform.position.x >= -7 && this.transform.position.x <= 7) // 이동 제한
        {
            MoveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // MoveDir 에 상하좌우 값 입력

            MoveDir = transform.TransformDirection(MoveDir); // rotation 을 신경쓰지않고 상하좌우값 입력

            MoveDir *= speed; // 스피드

            controller.Move(MoveDir * Time.deltaTime); // 컨트롤을 이용한 움직임
        }
        if (this.transform.position.x <= -7) // x 값 -7 넘으면 빼주는 역활
        {
            controller.Move(new Vector3(1, 0, 0) * Time.deltaTime);
        }
        if (this.transform.position.x >= 7) // x 값 7 넘으면 빼주는 역활
        {
            controller.Move(new Vector3(-1, 0, 0) * Time.deltaTime);
        }
    }
}
