## 간단한 핵앤슬래시 게임

게임이름 : (**미정**)  

무기를 선택하고, 대량의 적들을 물리치는 콘솔게임 프로젝트.  

## 기간

2026년 01월 08일 ~ 2026년 01월 12일 (5일간)

## 목적

- Unity에 입문하기 전, 게임엔진의 프레임워크구조를 대략적으로 이해하고, 게임을 직접 만들어본다.

- 이를 통해, 게임 내부 구조의 설계 이유를 어느정도 공감하고, 앞으로 더 고성능의 게임을 제작하는데 도움이 되길 바란다.

## 핵앤슬래시 선택이유

다음 4가지 조건들을 세웠다.

1. 혼자, 단기간에 만들 수 있어야 한다.

2. 맵이 없거나, 맵의 영향을 많이 받지 않는다.

3. 프레임에 변화를 줄 때, 영향을 체감할 수 있어야 한다.

4. 최소한의 게임성과 완성도를 챙기면서, 플레이타임 10분이상 보장해야 한다.

  

최대한 단순한 맵에서, 로그라이크 요소가 없는 **핵앤슬래시**는 단기간 내에 만들어볼 수 있겠다고 생각했다.  

추후에, 기능 추가해볼만 점들이 많아서, 객체지향의 유지보수적인 장점도 느껴볼 수 있을 거 같다.

  

## 프로젝트 구조
### Managers
- SceneManager
- ObjectManager
- InputManager
- TimeManager
- ConsoleManager
### Objects
- BaseObject
- BaseObject를 상속받는 각종 오브젝트들
### Scenes
- BaseScene
- BaseScene을 상속받는 각종 씬들
### Utils
- Log.cs : 로그관리
- ObservableProperty.cs : 옵저버패턴 속성
- TextList : 텍스트 List 출력
- TextExtensions : string 확장메서드
- Pos : 좌표관리
- Tile
- Inventory 
- ICollision : 충돌처리  
- IInteract : 플레이어와 상호작용
  
## 개발 핵심 기능

  
  

## 플레이 화면

