1. 메인 화면 구성

 - 캐릭터 직업
 - 플레이어 이름
 - 캐릭터 레벨
 - 캐릭터 경험치 바
 - 플레이어 골드
 - 플레이어 스프라이트
 - 행동 선택지 버튼 ( Status , Inventory , Shop )

 Player_DefaultStatusData(ScriptableObject) 로 초기값 설정 가능

2. Status

 - 캐릭터 스탯(공격력, 방어력, 체력, 속도) 표시

 Player_DefaultStatusData(ScriptableObject) 로 초기값 설정 가능

3. Inventory

 - 인벤토리창 상단 = 현재 아이템 갯수 , 최대 아이템 갯수 표시
 - 게임 시작시, GameManager에 있는 InventoryMaxSpace 의 수치만큼 인벤토리창에 아이템 슬롯(Button) 프리팹 생성
 - 아이템 슬롯 프리팹은 SetActive(false)상태로 생성되며, List<Item> Inventory 에 아이템이 추가될 때마다 true 로 변경
 - 아이템 장착 , 장착해제 (EquipPopup, Popup)
 - 동일 타입 아이템 중복 착용 불가 ( 헬멧, 아머, 부츠, 웨폰, 링 )
 - 아이템 장착시 [E] 표시
 - 아이템 장착 확인 팝업 (Popup)

 GameManager 인스펙터창을 통해 최대 아이템 갯수(InventoryMaxSpace) 조절 가능

4. Shop

 - 아이템 구매 (List<Item> Inventory 에 추가)
 - 소지 골드 부족, 인벤토리창 부족시 구매 불가.
 - 아이템 구매, 구매실패 팝업 (Popup)

 GameManager 인스펙터창을 통해 판매 아이템 추가 가능 (ShopItemList)

5. Item 추가

 - 빈 오브젝트 생성, 에셋메뉴(SpartaDungeonSO/Item/Equipment)를 통해 아이템 SO 생성 후, 빈 오브젝트에 Item.cs 컴포넌트 추가, 아이템 SO 참조 한 뒤 프리팹화.
