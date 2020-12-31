## 예제 코드에 관하여
책에서 예제 코드에 대해 충분히 설명하고 있으므로, 책을 가까이 두고 참조하면서, 유니티로 예제 코드를 동작시키거나 혹은 자유롭게 개조하여 동작 결과를 시각적으로 확인함으로써 학습 내용을 직감적으로 이해하고 응용할 수 있습니다. 

## 동작환경

* **Unity 5.3.0 f4**  이상 
	 - Unity 5.2.x에서 예제를 실행하고 싶을 때는 [Unity\_5.2 브런치][1]에서 다운로드 해주세요.
	- Microsoft Windows 7 이상 
	- Mac OS X 10.10 이상 


* Unity는Unity Technologies사의 웹사이트에서 무료버전인 Personal Edition를 선택해서 다운로드하고 설치해주세요. 
	- [최신버전][2]
	- [지난 버전][3]
	- [최신버전 이후 패치 릴리즈][4]
* 제공하는 예제 코드는 상기 버전에서 실행하는 것을 전제로 하고 있으므로, 그 이전 버전의 유니티를 같은 컴퓨터에서 이용해야만 할 때는 설치하는 폴더의 이름을 변경해서 여러 버전의 유니티를 공존하게 할 수 있습니다. 자세한 내용은 다음을 참고로 하기 바랍니다. 
* [다른 버전 동시설치(Installing Several Versions at Once) ][5]

## 예제 코드 구성
sample 폴더 내에 예제 코드의 유니티 프로젝트가 있고, Assets 폴더에 프로젝트를 구성하는 파일들이 포함됩니다.

- Editor: Unity Editor 확장 
- Meshes: 임포트할3D메쉬
- Resources: 머티리얼
- Scenes: Unity씬
- Scripts: C# 스크립트 컴포넌트
- Shader: GLSL 셰이더 프로그램

## 실행 방법
유니티에서 유니티 프로젝트로서 sample 폴더를 열고, 씬 재생 버튼을 눌러 실행합니다.

## 보충설명
대표적인 DCC(Digital Content Creation) 툴로는 Autodesk Maya를 들지만, 무료이고 오픈소스 3D 모델링으로는 [Blender][6]가 유명합니다. 

* 6장
	- 단위 사원수의 역수를 지정해서 회전하면, 원 사원수에 의한 회전의 역회전이 됩니다. 예제 코드 중의 Quaternion.Inverse는 인수로 주어진 단위 사원수의 역수를 반환합니다.

* 8장
	- TBDR의 장점/단점에 관해서는 그래픽 파이프라인 설명 읽은 후에 다시 한번 읽어보기 바랍니다. 
	- 지연 셰이딩은 9장에서 다루는 멀티패스 렌더링을 하므로, G버퍼 생성까지가 pass 1, G버퍼를 이용해 이루어지는(pass 1에서는 일부러 하지 않고 다음 pass까지 지연된) 조명 계산이 pass 2입니다.

* 9장
	 - 4차원 벡터를 나타내는 형  vec4는  x, y, z, w라는 4개의 멤버 변수를 갖는 구조체입니다. packednormal은 비트맵의 1픽셀을 나타내는 vec4로, RGBA각 채널을 각 멤버 변수에 저장합니다. 다시 말해, packednormal.w에 A(알파)가, p ackednormal.y에G(녹색)이 들어가므로, 스위즐 연산자 wy를 사용해 w와 y를 vec2로서 추출해서 전개합니다.
	- 예제 코드의 Chapter09 씬에 아래의 2가지 사양을 추가 
		a. 씬 재생시에 광원을 회전
		b. [유명한 3D 모델][7]인 [Utar teapot][8]과 스탠포드의 [Happy Budda][9]를 Blendar에 임포트하고, Blender 상에서 아래의 변경을 적용해 [Wavefront obj 포맷][10]으로 익스포트해서 유니티 씬에 배치 
	- 오리지널 머티리얼 삭제 
	- 서브메쉬를 join
	- 메쉬 내의 삼각형 수가 16bit로 표현할 수 없는 수치(65535) 이상이면 유니티에서의 임포트 시에 서브 메쉬로 분할되므로, Decimate Modifier로 Face Count를 65534 이하로 줄인다. 
			  
## 프로젝트가 열리지 않을 때
윈도우용 유니티에서 설치 환경에 따라선 제공하는 예제 프로젝트가 열리지 않는 경우가 있다. 그럴 때는 다음처럼 바로가기를 수정해서 유니티를 실행한 후 프로젝트를 불러온다. 

1. 컴퓨터 바탕화면에 생긴 Unity 바로가기 아이콘을 선택하고 우클릭해서 속성 창을 연다. 
2. 속성 창이 열리면 다음처럼 맨 뒤에 -force-opengl을 추가하고 저장한다. 

	대상(T): "C:\Program Files\Unity\Editor\Unity.exe" -force-opengl

3. 바로가기 아이콘을 통해 유니티를 실행하고 프로젝트를 연다.

## 다운로드
최신 예제 코드는 본 git 레포지터리의 [master 브런치][11]에 수록되어 있습니다.
아래 방법 중 하나로 예제 코드를 내려받습니다.

* 본 레포지터리의 메뉴에서 Download Zip 버튼으로 일괄 다운로드
* git 클라이언트로 로컬 PC에 레포지토리를 clone
* github 계정이 있다면 본 레포지터리를 자신의 레포지터리로 fork


## 정오표
출판사 도서 지원 페이지를 참조하세요. 

## 저자강연자료

* [게임앱수학@Unity Rendering Wizard 모임][12]
	- 2015년 10월 22일 시부야渋谷dots.에서 개최된[Unity Rendering Wizard][13]에서의 LT자료입니다.
* [게임앱수학@프로그래머를 위한 수학 스터디][14]
	- 2015년 11월 21일 시부야dots.에서 개최된[제5회 프로그래머를 위한 수학 스터디][15] [^maths4pg](https://twitter.com/hashtag/maths4pg?src=hash)에서의 LT자료입니다.
* [게임앱수학@GREE GameDevelopers' Meetup][16]
	- 2015년 12월 6일 록본기힐즈 그리 주식회사에서 개최된[GREE GameDevelopers' Meetup 02][17] [^greegdm02](https://twitter.com/hashtag/greegdm02?src=hash)에서의 강연자료입니다. 본서적의 소개와 번외편(레이 트레이싱/레이 매칭/SDF 등, 래스터라이즈 하지 않는 비폴리곤 기반 3D그래픽 소개), 게임 개발의 미래 전망(절차 생성, 기계 학습/ 딥러닝, 모바일VR 등)으로 구성됩니다.

## 라이선스

본 예제 코드는 [CC BY-SA/Creative Commons Attribution Share Alike 4.0][18] 라이선스를 따릅니다.

## 저자 연락처

* [Twitter][19]
* [blog][20]

## 갱신 이력

* 2015-12-18 저자강연추가
* 2015-12-18 Unity 5.3 지원 (Unity 5.3.0f4)
* 2015-12-18 Unity 5.2용 브런치 추가 (Unity\_5.2)(Unity 5.2.4f1)
* 2015-09-29 보충설명
* 2015-09-26 보충설명
* 2015-09-22 보충설명
* 2015-09-19 초판 





[1]:	https://github.com/ryukbk/mobile_game_math_unity/tree/Unity_5.2
[2]:	https://unity3d.com/kr/get-unity/download
[3]:	https://unity3d.com/kr/get-unity/download/archive
[4]:	https://unity3d.com/kr/unity/qa/patch-releases
[5]:	http://docs.unity3d.com/kr/current/Manual/InstallingUnity.html
[6]:	https://www.blender.org/
[7]:	https://en.wikipedia.org/wiki/List_of_common_3D_test_models
[8]:	https://en.wikipedia.org/wiki/Utah%5C_teapot
[9]:	http://graphics.stanford.edu/data/3Dscanrep/
[10]:	https://en.wikipedia.org/wiki/Wavefront_.obj_file
[11]:	https://github.com/ryukbk/mobile_game_math_unity/tree/master
[12]:	http://www.slideshare.net/ryukbk/unity-rendering-wizard
[13]:	http://eventdots.jp/event/571325
[14]:	http://www.slideshare.net/ryukbk/ss-55366793
[15]:	http://eventdots.jp/event/571642
[16]:	http://www.slideshare.net/ryukbk/gree-gamedevelopers-meetup
[17]:	http://greegdm02.peatix.com/
[18]:	https://creativecommons.org/licenses/by-sa/4.0/deed.ja
[19]:	https://twitter.com/ryukbk
[20]:	http://ryukbk.blogspot.jp/