using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PartTimeGame : MonoBehaviour
{
    public GameObject[] keyBoardPrefabs; //키보드 이미지를 가진 오브젝트 리스트
    public KeyCode[] possibleKeys; //실제 입력할 키보드 리스트 (방향키, 스페이스바)

    //public Transform keySpawnArea; // 키보드가 스폰할 지역 (BackGround 오브젝트)
    public float xOffset = 1.5f; // X축 간격 조절 값

    public static int turn; //지금 어떤 오브젝트를 입력할 차례인지 (0에서 시작)
    private static int stageNum = 1;
    public static List<GameObject> spawnedKeyboards = new List<GameObject>();

    [SerializeField]
    private TextMeshProUGUI stageNumText;
    [SerializeField]
    private TextMeshProUGUI moneyNumText;
    [SerializeField]
    private TextMeshProUGUI moneyNumInGameText;
    [SerializeField]
    private TextMeshProUGUI StartArrowText;

    public int money = 0;

    private void Start()
    {
        stageNum = 1;
        money = 0;
    }

    public void SpawnKeyBoards()
    {
        foreach (GameObject keyboard in spawnedKeyboards)
        {
            Destroy(keyboard);
        }
        spawnedKeyboards.Clear();
        turn = 0;
        int index = 0;   //현재 생성된 키보드 오브젝트가 몇번째로 생성됐는지 나타내는 index변수

        for (float i = 0; i < 20; i++) // 키보드 총 20개 생성
        {
            if (i < 5)
            {
                float yPos = 2.5f - 1.5f*i;
                Vector3 spawnPosition = new Vector3 (-4.5f, yPos, 0);
                int randNum = Random.Range(0, possibleKeys.Length);
                GameObject selectedPrefab = keyBoardPrefabs[randNum];
                GameObject keyObject = Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);
                spawnedKeyboards.Add(keyObject);
                PartTimeGameKeyBoard keyScript = keyObject.GetComponent<PartTimeGameKeyBoard>(); //생성된 오브젝트의 키보드 스크립트 가져오기
                keyScript.SetKeySprite(possibleKeys[randNum], index++);
            }

            else if (i < 10)
            {
                float xPos = 1.8f*(i - 5) - 2.7f;
                Vector3 spawnPosition = new Vector3 (xPos, -3.5f, 0);
                int randNum = Random.Range(0, possibleKeys.Length);
                GameObject selectedPrefab = keyBoardPrefabs[randNum];
                GameObject keyObject = Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);
                spawnedKeyboards.Add(keyObject);
                PartTimeGameKeyBoard keyScript = keyObject.GetComponent<PartTimeGameKeyBoard>(); //생성된 오브젝트의 키보드 스크립트 가져오기
                keyScript.SetKeySprite(possibleKeys[randNum], index++);
            }

            else if (i < 14)
            {
                float yPos = -2f + 1.5f*(i - 10);
                Vector3 spawnPosition = new Vector3 (4.5f, yPos, 0);
                int randNum = Random.Range(0, possibleKeys.Length);
                GameObject selectedPrefab = keyBoardPrefabs[randNum];
                GameObject keyObject = Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);
                spawnedKeyboards.Add(keyObject);
                PartTimeGameKeyBoard keyScript = keyObject.GetComponent<PartTimeGameKeyBoard>(); //생성된 오브젝트의 키보드 스크립트 가져오기
                keyScript.SetKeySprite(possibleKeys[randNum], index++);
            }

            else if (i < 17)
            {
                float xPos = 2.7f - 1.8f*(i - 14);
                Vector3 spawnPosition = new Vector3 (xPos, 2.5f, 0);
                int randNum = Random.Range(0, possibleKeys.Length);
                GameObject selectedPrefab = keyBoardPrefabs[randNum];
                GameObject keyObject = Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);
                spawnedKeyboards.Add(keyObject);
                PartTimeGameKeyBoard keyScript = keyObject.GetComponent<PartTimeGameKeyBoard>(); //생성된 오브젝트의 키보드 스크립트 가져오기
                keyScript.SetKeySprite(possibleKeys[randNum], index++);
            }

            
            else if (i < 19)
            {
                float yPos = 1f - 1.5f*(i - 17);
                Vector3 spawnPosition = new Vector3 (-0.9f, yPos, 0);
                int randNum = Random.Range(0, possibleKeys.Length);
                GameObject selectedPrefab = keyBoardPrefabs[randNum];
                GameObject keyObject = Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);
                spawnedKeyboards.Add(keyObject);
                PartTimeGameKeyBoard keyScript = keyObject.GetComponent<PartTimeGameKeyBoard>(); //생성된 오브젝트의 키보드 스크립트 가져오기
                keyScript.SetKeySprite(possibleKeys[randNum], index++);
            }

            else
            {
                Vector3 spawnPosition = new Vector3 (0.9f, -0.5f, 0);
                int randNum = Random.Range(0, possibleKeys.Length);
                GameObject selectedPrefab = keyBoardPrefabs[randNum];
                GameObject keyObject = Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);
                spawnedKeyboards.Add(keyObject);
                PartTimeGameKeyBoard keyScript = keyObject.GetComponent<PartTimeGameKeyBoard>(); //생성된 오브젝트의 키보드 스크립트 가져오기
                keyScript.SetKeySprite(possibleKeys[randNum], index++);
            }
            
            // float xPos = 1.5f*i-6f; // 스폰될 오브젝트의 x좌표 -6, -4.5, -3, -1.5, 0, 1.5, 3, 4.5, 6 
            // Vector3 spawnPosition = new Vector3(xPos, 0, 0); //스폰좌표를 vector3로 설정
            // int randNum = Random.Range(0, possibleKeys.Length);
            // GameObject selectedPrefab = keyBoardPrefabs[randNum]; // 키보드 이미지 프리팹 중에서 랜덤으로 하나 오브젝트 뽑음
            // GameObject keyObject = Instantiate(selectedPrefab, spawnPosition, Quaternion.identity); //뽑은 오브젝트 생성
            // spawnedKeyboards.Add(keyObject);
            // PartTimeGameKeyBoard keyScript = keyObject.GetComponent<PartTimeGameKeyBoard>(); //생성된 오브젝트의 키보드 스크립트 가져오기
            // keyScript.SetKeySprite(possibleKeys[randNum], index++); //index 변수 증가
        }
    }

    public void increaseStageNum()
    {
        stageNum++;
        stageNumText.SetText(stageNum.ToString());
    }

    public void moneyManager()
    {
        money += 5;
        moneyNumText.SetText(money.ToString() + "만원");
    }

    void Update()
    {
        moneyNumInGameText.SetText(money.ToString()+"만원");
        
        if (PartTimeGameTimer.totalTime < 0)
        {
            foreach (GameObject keyboard in spawnedKeyboards)
            {
                Destroy(keyboard);
            }
            spawnedKeyboards.Clear();
        }

        if (turn == 1)
        {
            StartArrowText.SetText("");
        }
        
        if (turn == 20)
        {
            turn = 0;
            increaseStageNum();
            moneyManager();
            SpawnKeyBoards();

            // if (stageNum < 6)
            //     SpawnKeyBoards();
        }

        // if (stageNum == 6)
        // {
        //     stageNum++;
        //     foreach (GameObject keyboard in spawnedKeyboards)
        //     {
        //         Destroy(keyboard);
        //     }
        //     spawnedKeyboards.Clear();
        //     StartPanel.SetActive(false);
        //     EndPanel.SetActive(true);
        //     moneyNumText.SetText(money.ToString()+"만원");
        //     StatusChanger.EarnMoney(money);
        //     //GameObject.FindWithTag("StatusChanger").GetComponent<StatusChanger>().earnMoney(money);
        // }
    }

    // if (Timer.LimitTime < 0)
    // {
    //     StageNumPanel.SetActive(false);
    //     EndStagePanel.SetActive(true);
    //     stageNum = 1;
    //     Timer.LimitTime = 15f;
            
    //     foreach (GameObject keyboard in spawnedKeyboards)
    //     {
    //         Destroy(keyboard);
    //     }
    //     spawnedKeyboards.Clear();
    // }

    // if (turn == 9)
    // {
    //     turn = 0;
    //     increaseStageNum();
    //     SpawnKeyBoards();
    // }
}