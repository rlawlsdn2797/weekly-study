using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManiger : MonoBehaviour
{

    int playerSpeed = 10; // 플레이어 속도
    Rigidbody2D rid2D; // 리지드바디 선언

    // Start is called before the first frame update
    private void Start()
    {
        rid2D = GetComponent<Rigidbody2D>(); // 현재 스크립트를 가지고 있는 오브젝트 리지드바드 가져오기
        rid2D.gravityScale = 0; // 중력 영향 제거
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow)) // 오른쪽 화살표를 눌렀을 떄 실행
        {
            rid2D.AddForce(new Vector2(playerSpeed, 0), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) // 왼쪽 화살표를 눌렀을 때 실행
        {
            rid2D.AddForce(new Vector2(-playerSpeed, 0), ForceMode2D.Force);
        }
    }
}
