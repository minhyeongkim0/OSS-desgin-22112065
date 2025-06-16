실행환경 
비주얼스튜디오 C# 2019 이상
NET Framework 4.8 이상 
실행방법
1. Visual Studio에서 WindowsFormsApp19.sln 열기
2. NuGet 패키지 복원 (필요 시)
   - 도구 > NuGet 패키지 관리자 > 패키지 복원
   - 또는 콘솔에서: Install-Package System.Data.SQLite
3. F5 (디버그 시작) 또는 Ctrl + F5 (디버그 없이 시작)으로 실행

최초 점주코드(암호) 0000
주의사항 
데이터 그리드 뷰에서 선택할때 해당행의 가장 왼쪽열 클릭하면됨 
중복선택시 ctrl 누르고 클릭 
실행중 데이터테이블의 컬럼이 찾아지지않는 오류뜰시 탐색기에서 mydb.sqlite 검색후 삭제 후 다시실행
mydb.sqlite  데이터 베이스
여러메뉴 주문시 주문번호는 메뉴종류 별로 들어간다. 