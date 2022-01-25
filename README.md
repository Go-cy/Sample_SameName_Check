# C# 동명이인 체크 Sample code 

기본적으로 UltraGrid 나 DataGridView 이용을 염두해 제작

기존 레거시 코드에 이중 For문으로 RowCont만큼 돌리게 되어있어서 성능 개선 필요해 수정하는 겸 샘플코드 작성함.

예상 시간복잡도

기존 : 2중 for문 - N^2  

변경 : Dictionary - 2N

사용법 
1. DataSet 눌러 이름입력
2. Check 눌러서 동명이인 확인

---
예시 이미지
1. 
![image](https://user-images.githubusercontent.com/31956098/150940512-00171236-16db-48e8-89fd-b519236167d3.png)
2. 
![image](https://user-images.githubusercontent.com/31956098/150940794-4acfdbf9-8489-4aea-bc73-06f1606172c3.png)
