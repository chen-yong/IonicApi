

ionic APP API

## �ӿ�˵��

�ӿڲ���POST��ʽͨ��URL��ȡ���ݣ� ���ظ�ʽΪjson/text��utf-8���롣

retcode��

1. ���������Ϊ0
2. ����

| ������ | ˵��                      |
| ------ | ------------------------- |
| 11     | ��������                  |
| 12     | �������ڲ�����            |
| 13     | ��֤���ƣ�authtoken��ʧЧ |
| 99     | δ֪����                  |

���Թ��ߣ�postman��Ĭ������ʽ��get

### 1.��¼

```http 
http://api/Login/Login?username=&password=
```

������

| ������   | ����   | �Ƿ�ɿ� | ��ע |
| -------- | ------ | -------- | ---- |
| username | string | ��       | �˺� |
| password | string | ��       | ���� |

���أ�

| �ֶ�      | ����          | ˵��     |
| --------- | ------------- | -------- |
| retcode   | int           | ������   |
| authtoken | string        | ��¼֤�� |
| info      | array[object] |          |
| type      | int           | �û����� |
| id        | int           | �û�id   |
| name      | string        | ����     |
| gender    | int           | �Ա�     |
| phone     | string        | �ֻ���   |
| imgurl    | string        | ͷ��·�� |

```json
{
    "retcode" : 0,
    "authtoken" : "3wfsf2323r2342112",
    "info" : {
        "type" : 0,
        "name" :"����",
        "gender" :0,
        "phone" : "13708187211",
        "imgurl" : "ͼƬ·��"
    }
}
```



### 2.�γ�

#### 1.��ȡ�γ��б�

```
http://api/getCourse?authtoken
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��     |
| --------- | ------ | -------- | -------- |
| authtoken | string | ��       | ��¼֤�� |

���أ�

| �ֶ�       | ����          | ˵��     |
| ---------- | ------------- | -------- |
| retcode    | int           | ������   |
| courseinfo | array[object] |          |
| id         | int           | �γ�id   |
| name       | string        | �γ����� |
| intro      | string        | �γ̼�� |
| logo       | string        | �γ�ͼ�� |

```json
{
  "retcode" : 0,
  "courseinfo": [
     {
        "id":1,
        name:"angular",
        intro:"angulat��顭��",
        logo:"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
  	 },
      {
        "id":2,
        name:"vue",
        intro:"vue��顭��",
        logo:"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
  	 },
      ����
  ]
}
```



#### 2.ѧ���б�

```
http://api/getStudentList?courseId=1
```

������

| ������   | ���� | �Ƿ�ɿ� | ˵��   |
| -------- | ---- | -------- | ------ |
| courseId | int  | ��       | �γ�Id |

���أ�

| �ֶ�        | ����          | ˵��     |
| ----------- | ------------- | -------- |
| retcode     | int           | ������   |
| studentList | array[object] |          |
| id          | int           | ѧ��id   |
| name        | string        | ѧ������ |
| img         | string        | ѧ��ͷ�� |

```json
{
    "retcode":0,
	"studentList"��[
        {
           "id":"1",
           "name":"����",
           "img":"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
        },
        {
           "id":"2",
           "name":"����",
           "img":"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
        },
        ����
	]
}
```

##### 1.ѧ������

```
http://api/getStudentInfo?id=1
```

������

| ������ | ���� | �Ƿ�ɿ� | ˵��   |
| ------ | ---- | -------- | ------ |
| id     | int  | ��       | ѧ��id |

����:

| �ֶ�        | ����          | ˵��             |
| ----------- | ------------- | ---------------- |
| retcode     | int           | ������           |
| studentInfo | array[object] |                  |
| number      | int           | ѧ��             |
| name        | string        | ����             |
| college     | string        | ѧԺ��ϵ         |
| class       | string        | �༶             |
| gender      | int           | �Ա�0�У�1Ů�� |
| phone       | string        | �绰             |

```json
{
    "retcode" : 0, 
	"studentInfo":{
		"number":"001",
		"name":"����",
		"college":"��Ϣ����",
		"class":"һ��",
		"gender":"0",
		"phone":"18896761234"
	}
}
```

##### 2.���ѧ��

[post]

```http 
http://api/Users/AddCourseStudent?courseId=422
```

������

| ������         | ����          | �Ƿ�ɿ� | ˵��                   |
| -------------- | ------------- | -------- | ---------------------- |
| courseId       | int           | ��       | �γ�id                 |
| addUser        | array[object] |          |                        |
| userName       | string        | ��       | �˺�                   |
| realName       | string        | ��       | ��ʵ����               |
| userIdentity00 | string        | ��       | ѧԺ��ϵ               |
| property02     | string        | ��       | �༶                   |
| sex            | string        | ��       | �Ա��У�Ů��Ĭ���У� |
| mobile         | string        | ��       | �绰                   |

���͸�ʽ��Body+raw+Json

```json
{
	"userName":"2015210402020",
	"RealName":"����",
	"userIdentity00":"�����153",
	"property02":"",
	"sex":"Ů",
	"mobile":""
}
```

����:

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json 
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "ѧ���������γ��гɹ�"
}
```



##### 3.�༭ѧ��

```http
http://api/Users/EditUser?id=35899
```

   [HttpPatch]

�й�HttpPatch�ֲ����²���ת��������ӣ�

```json 
https://www.cnblogs.com/bijinshan/p/9140111.html
```

���� params��

| ������ | ���� | �Ƿ�ɿ� | ˵��   |
| ------ | ---- | -------- | ------ |
| id     | int  | ��       | ѧ��id |

Headers ��

| key          | value                       |
| ------------ | --------------------------- |
| Content-Type | application/json-patch+json |

Body: 

```json
[
	{
		"op":"replace",
		"path":"/userName",
		"value":"chenyong1"
	},
	{
		"op":"replace",
		"path":"/RealName",
		"value":"123"
	},
	{
		"op":"replace",
		"path":"/Password",
		"value":"E10ADC3949BA59ABBE56E057F20F883E"
	},
	{
		"op":"replace",
		"path":"/sex",
		"value":"��"
	},
	{
		"op":"add",
		"path":"/UserIdentity01",
		"value":"1"
	},
		{
		"op":"add",
		"path":"/UserIdentity03",
		"value":"1"
	}
]

```

����:

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "�޸ĳɹ�"
}
```



##### 4.ɾ��ѧ��

```
http://api/deleteStudent?id=1
```

������

| ������ | ���� | �Ƿ�ɿ� | ˵��   |
| ------ | ---- | -------- | ------ |
| id     | int  | ��       | ѧ��id |

����:

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{
  "retcode" : 0
}
```



##### 5.��������

```
http://api/resetPwd?id
```

������

| ������ | ���� | �Ƿ�ɿ� | ˵��   |
| ------ | ---- | -------- | ------ |
| id     | int  | ��       | ѧ��id |

���أ�

```
{
  "retcode" : 0
}
```



##### 6.����ѧ��

```
http://api/search?keywords
```

������

| ������   | ����   | �Ƿ�ɿ� | ˵��       |
| -------- | ------ | -------- | ---------- |
| keywords | string | ��       | �����ؼ��� |

���أ�

| �ֶ�        | ����          | ˵��     |
| ----------- | ------------- | -------- |
| retcode     | int           | ������   |
| studentList | array[object] |          |
| id          | int           | ѧ��id   |
| name        | string        | ѧ������ |
| img         | string        | ѧ��ͷ�� |

```json
{
  "retcode" : 0,
  "studentList"��[
        {
           "id":"1",
           "name":"����",
           "img":"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
        },
        {
           "id":"2",
           "name":"����",
           "img":"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
        },
        ����
	]
}
```



#### 3.��ҵ�б�

```
http://api/getWorktList?courseId=1
```

������

| ������   | ���� | �Ƿ�ɿ� | ˵��   |
| -------- | ---- | -------- | ------ |
| courseId | int  | ��       | �γ�id |

���أ�

| �ֶ�     | ����          | ˵��     |
| -------- | ------------- | -------- |
| workinfo | array[object] |          |
| id       | int           | ��ҵid   |
| name     | string        | ��ҵ���� |

```json
{
  "workinfo": [
      {
         "id":1,
         "name":"��ҵ1"
  	 },
       {
         "id":2,
         "name":"��ҵ2"
  	 },
      ����
  ]
}
```

##### 1. �����ҵ

```
http://api/addWork?courseId=1&workinfo=
```

������

| ������               | ����          | �Ƿ�ɿ� | ˵��                              |
| -------------------- | ------------- | -------- | --------------------------------- |
| courseId             | int           | ��       | �γ�id                            |
| workinfo             | array[object] | ��       |                                   |
| name                 | string        | ��       | ��ҵ����                          |
| tactics              | string        | ��       | �������                          |
| startTime            | string        | ��       | ��ʼʱ��yyyyMMddHHmmss            |
| endTime              | string        | ��       | ����ʱ��yyyyMMddHHmmss            |
| addTime              | string        | ��       | ������ֹʱ��yyyyMMddHHmmss        |
| score                | int           | ��       | �ܷ�                              |
| flag                 | int           | ��       | ��ҵ������Ĭ��0,��������1�������� |
| flagTime             | string        | ��       | ������ֹʱ��                      |
| showGrade            | bool          | ��       | ����չʾ                          |
| parRadioList         | array         | ��       | �����б�                          |
| forbidCopy           | bool          | ��       | ��ֹ������Ŀ��Ĭ��false��         |
| forbidRightClick     | bool          | ��       | ��ֹ�Ҽ���Ĭ��false��             |
| enableClientJudge    | bool          | ��       | ����ѧ�����ľ�Ĭ��false��       |
| viewOneWithAnswerKey | bool          | ��       | ���ʱ��׼�𰸿ɼ���Ĭ��false��   |

���ݸ�ʽ��json

```json
{
    "workinfo":[
        {
            "name":"��ҵ����",
            "tictics":"�������",
            "startTime":"��ʼʱ��",
            "endTime":"����ʱ��",
            "addTime":"����ʱ��",
            "scroe":"�ܷ�",
            "flag":"0",
            "flagTime":"������ֹʱ��",
            "showGrade":"false",
            "parRadioList":[
               {
                 "forbidCopy":"false",
                 "forbidCopy" : "false",
            	 "enableClientJudge" : "true",
            	 "viewOneWithAnswerKey" : "false"
               }
            ]
        }
    ]
}
```

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

##### 2. �༭��ҵ(����)

```
http://api/editWork?workId=1
```

������

| ������               | ����          | �Ƿ�ɿ� | ˵��                              |
| -------------------- | ------------- | -------- | --------------------------------- |
| workId               | int           | ��       | ��ҵid                            |
| workinfo             | array[object] | ��       |                                   |
| name                 | string        | ��       | ��ҵ����                          |
| tactics              | string        | ��       | �������                          |
| startTime            | string        | ��       | ��ʼ����yyyyMMddHHmmss            |
| endTime              | string        | ��       | ����ʱ��yyyyMMddHHmmss            |
| addTime              | string        | ��       | ������ֹʱ��yyyyMMddHHmmss        |
| score                | int           | ��       | �ܷ�                              |
| flag                 | int           | ��       | ��ҵ������Ĭ��0,��������1�������� |
| flagTime             | string        | ��       | ������ֹʱ��                      |
| showGradeList        | int           | ��       | ����չʾ                          |
| parRadioList         | array         | ��       | �����б�                          |
| forbidCopy           | bool          | ��       | ��ֹ������Ŀ��Ĭ��false��         |
| forbidRightClick     | bool          | ��       | ��ֹ�Ҽ���Ĭ��false��             |
| enableClientJudge    | bool          | ��       | ����ѧ�����ľ�Ĭ��false��       |
| viewOneWithAnswerKey | bool          | ��       | ���ʱ��׼�𰸿ɼ���Ĭ��false��   |

���ݸ�ʽ��json

```json
{
    "workinfo":[
        {
            "name":"��ҵ����",
            "tictics":"�������",
            "startTime":"��ʼʱ��",
            "endTime":"����ʱ��",
            "addTime":"����ʱ��",
            "scroe":"�ܷ�",
            "flag":"0",
            "flagTime":"������ֹʱ��",
            "showGrade":"false",
            "parRadioList":[
               {
                 "forbidCopy":"false",
                 "forbidCopy" : "false",
            	 "enableClientJudge" : "true",
            	 "viewOneWithAnswerKey" : "false"
               }
            ]
        }
    ]
}
```

 ���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

##### 3. ɾ����ҵ

```
http://api/deleteWork?workId=1
```

������

| ������ | ���� | �Ƿ�ɿ� | ˵��   |
| ------ | ---- | -------- | ------ |
| workId | int  | ��       | �γ�id |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

#####  4. ��ҵ����

```
http://api/readWork?workId=1
```

������

| ������ | ���� | �Ƿ�ɿ� | ˵��   |
| ------ | ---- | -------- | ------ |
| workId | int  | ��       | �γ�id |

���أ�

```json
{  
 	"retcode" : 0
}
```

#### 4.ʵ���б�

```
http://api/getLabtList?courseId=1
```

������

| ������   | ���� | �Ƿ�ɿ� | ˵��   |
| -------- | ---- | -------- | ------ |
| courseId | int  | ��       | �γ�id |

���أ�

| �ֶ�    | ����          | ˵��     |
| ------- | ------------- | -------- |
|         | int           | ������   |
| labinfo | array[object] |          |
| id      | int           | ��ҵid   |
| name    | string        | ��ҵ���� |

```json
{
  "retcode":0,
  "labinfo": [
      {
         "id":1,
         "name":"ʵ��1"
  	 },
       {
         "id":2,
         "name":"ʵ��2"
  	 },
      ����
  ]
}
```

##### 1. ���ʵ��

```
http://api/addLab?courseId=1&labinfo
```

������

| ������               | ����          | �Ƿ�ɿ� | ˵��                            |
| -------------------- | ------------- | -------- | ------------------------------- |
| courseId             | int           | ��       | �γ�id                          |
| labinfo              | array[object] | ��       |                                 |
| name                 | string        | ��       | ʵ������                        |
| tactics              | string        | ��       | �������                        |
| startTime            | string        | ��       | ��ʼ����yyyyMMddHHmmss          |
| endTime              | string        | ��       | ����ʱ��yyyyMMddHHmmss          |
| addTime              | string        | ��       | ������ֹʱ��yyyyMMddHHmmss      |
| score                | int           | ��       | �ܷ�                            |
| flag                 | int           | ��       | ������Ĭ��0,��������1��������   |
| flagTime             | string        | ��       | ������ֹʱ��                    |
| showGradeList        | int           | ��       | ����չʾ                        |
| parRadioList         | array         | ��       | �����б�                        |
| forbidCopy           | bool          | ��       | ��ֹ������Ŀ��Ĭ��false��       |
| forbidRightClick     | bool          | ��       | ��ֹ�Ҽ���Ĭ��false��           |
| enableClientJudge    | bool          | ��       | ����ѧ�����ľ�Ĭ��false��     |
| viewOneWithAnswerKey | bool          | ��       | ���ʱ��׼�𰸿ɼ���Ĭ��false�� |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

##### 2. �༭ʵ��

```
http://api/editLab?LabId=1&labinfo
```

������

| ������               | ����          | �Ƿ�ɿ� | ˵��                            |
| -------------------- | ------------- | -------- | ------------------------------- |
| LabId                | int           | ��       | ʵ��id                          |
| labinfo              | array[object] | ��       |                                 |
| name                 | string        | ��       | ʵ������                        |
| tactics              | string        | ��       | �������                        |
| startTime            | string        | ��       | ��ʼ����yyyyMMddHHmmss          |
| endTime              | string        | ��       | ����ʱ��yyyyMMddHHmmss          |
| addTime              | string        | ��       | ������ֹʱ��yyyyMMddHHmmss      |
| score                | int           | ��       | �ܷ�                            |
| flag                 | int           | ��       | ������Ĭ��0,��������1��������   |
| flagTime             | string        | ��       | ������ֹʱ��                    |
| showGradeList        | int           | ��       | ����չʾ                        |
| parRadioList         | array         | ��       | �����б�                        |
| forbidCopy           | bool          | ��       | ��ֹ������Ŀ��Ĭ��false��       |
| forbidRightClick     | bool          | ��       | ��ֹ�Ҽ���Ĭ��false��           |
| enableClientJudge    | bool          | ��       | ����ѧ�����ľ�Ĭ��false��     |
| viewOneWithAnswerKey | bool          | ��       | ���ʱ��׼�𰸿ɼ���Ĭ��false�� |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

##### 3. ɾ��ʵ��

```
http://api/deleteLab?labId=1
```

������

| ������ | ���� | �Ƿ�ɿ� | ˵��   |
| ------ | ---- | -------- | ------ |
| labId  | int  | ��       | ʵ��id |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

##### 4. ����ʵ��

```
http://api/readLab?labId=1
```

������

| ������ | ���� | �Ƿ�ɿ� | ˵��   |
| ------ | ---- | -------- | ------ |
| labId  | int  | ��       | ʵ��id |

���أ�

```json
{  
 	"retcode" : 0
}
```

#### 5.��ϰ�б�

```
http://api/getExerciseList?courseId=1
```

������

| ������   | ���� | �Ƿ�ɿ� | ˵��   |
| -------- | ---- | -------- | ------ |
| courseId | int  | ��       | �γ�id |

���أ�

| �ֶ�         | ����          | ˵��     |
| ------------ | ------------- | -------- |
| exerciseinfo | array[object] |          |
| id           | int           | ��ϰid   |
| name         | string        | ��ϰ���� |

```json
{
  "exerciseinfo": [
      {
         "id":1,
         "name":"��ϰ1"
  	 },
       {
         "id":2,
         "name":"��ϰ2"
  	 },
      ����
  ]
}
```

##### 1. �����ϰ

```
http://api/addExercise?courseId=1
```

������

| ������       | ����          | �Ƿ�ɿ� | ˵��                   |
| ------------ | ------------- | -------- | ---------------------- |
| courseId     | int           | ��       | �γ�id                 |
| exerciseinfo | array[object] | ��       |                        |
| name         | string        | ��       | ��ϰ����               |
| tactics      | string        | ��       | �������               |
| startTime    | string        | ��       | ��ʼ����yyyyMMddHHmmss |
| endTime      | string        | ��       | ����ʱ��yyyyMMddHHmmss |
| parRadioList | array         | ��       | �����б�               |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

##### 2. �༭��ϰ

```
http://api/deleteExercise?exerciseId=1
```

������

| ������       | ����          | �Ƿ�ɿ� | ˵��                   |
| ------------ | ------------- | -------- | ---------------------- |
| exerciseId   | int           | ��       | ��ϰid                 |
| exerciseinfo | array[object] | ��       |                        |
| name         | string        | ��       | ��ϰ����               |
| tactics      | string        | ��       | �������               |
| startTime    | string        | ��       | ��ʼ����yyyyMMddHHmmss |
| endTime      | string        | ��       | ����ʱ��yyyyMMddHHmmss |
| parRadioList | array         | ��       | �����б�               |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

##### 3. ɾ����ϰ

```
http://api/deleteExercise?exerciseId=1
```

������

| ������     | ���� | �Ƿ�ɿ� | ˵��   |
| ---------- | ---- | -------- | ------ |
| exerciseId | int  | ��       | ��ϰid |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

#### 6.�γ���Դ

##### 1. ��ȡ��Դ�б�

```
http://api/getResource/courseId=1
```

������

| ������   | ���� | �Ƿ�ɿ� | ˵��   |
| -------- | ---- | -------- | ------ |
| courseId | int  | ��       | �γ�id |

���أ�

| �ֶ�         | ����          | ˵��         |
| ------------ | ------------- | ------------ |
| retcode      | int           | ������       |
| resourceList | array[object] |              |
| fileId       | int           | �ļ�id       |
| fileName     | string        | �ļ���       |
| fileSize     | float         | �ļ���С     |
| fileType     | string        | �ļ�����     |
| fileUrl      | string        | �ļ�·��     |
| createdDate  | string        | �ļ��������� |

```json
{  
 	"retcode" : 0,
    "resourceList":[
        {
            "fileId":1,
            "fileName":"�ļ���1",
            "fileSize":"100",
            "fileType":"�ļ�����",
            "fileUrl":"�ļ�·��",
            "createdDate":"yyyyMMddHHmmss"
        },
        {
            "fileId":2,
            "fileName":"�ļ���1",
            "fileSize":"100",
            "fileType":"�ļ�����",
            "fileUrl":"�ļ�·��",
            "createdDate":"yyyyMMddHHmmss"
        },
        ����
    ]
}
```

##### 2. �ϴ��ļ�

```
http://api/upFile?courseId=1
```

������

| ������   | ����          | �Ƿ�ɿ� | ˵��         |
| -------- | ------------- | -------- | ------------ |
| courseId | int           | ��       | �γ�id       |
| fileData | array[object] | ��       | �����ļ���Ϣ |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

##### 3. ɾ����Դ

```
http://api/deleteFile/id=1
```

������

| ������ | ���� | �Ƿ�ɿ� | ˵��   |
| ------ | ---- | -------- | ------ |
| id     | int  | ��       | ��Դid |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

##### 4. ������Դ

```
http://api/searchFile?keywords
```

������

| ������   | ����   | �Ƿ�ɿ� | ˵��   |
| -------- | ------ | -------- | ------ |
| keywords | string | ��       | �ؼ��� |

���أ�

| �ֶ�         | ����          | ˵��         |
| ------------ | ------------- | ------------ |
| retcode      | int           | ������       |
| resourceList | array[object] |              |
| fileId       | int           | �ļ�id       |
| fileName     | string        | �ļ���       |
| fileSize     | float         | �ļ���С     |
| fileType     | string        | �ļ�����     |
| fileUrl      | string        | �ļ�·��     |
| createdDate  | string        | �ļ��������� |

```json
{  
 	"retcode" : 0,
    "resourceList":[
        {
            "fileId":1,
            "fileName":"�ļ���1",
            "fileSize":"100",
            "fileType":"�ļ�����",
            "fileUrl":"�ļ�·��",
            "createdDate":"yyyyMMddHHmmss"
        },
        {
            "fileId":2,
            "fileName":"�ļ���1",
            "fileSize":"100",
            "fileType":"�ļ�����",
            "fileUrl":"�ļ�·��",
            "createdDate":"yyyyMMddHHmmss"
        },
        ����
    ]
}
```

#### 7.��ҵ�ɼ�

```
http://api/workGradeList?courseId=1
```

������

| ������   | ���� | �Ƿ�ɿ� | ˵��             |
| -------- | ---- | -------- | ---------------- |
| courseId | int  | ��       | �γ�id           |
| count    | int  | ��       | ÿҳ��¼����     |
| page     | int  | ��       | �ڼ�ҳ�� ��1��ʼ |

���أ�

| �ֶ�        | ����          | ˵��           |
| ----------- | ------------- | -------------- |
| retcode     | int           | ������         |
| pagecount   | int           | �����ܹ��м�ҳ |
| recordcount | int           | �ܹ���¼��     |
| isfirst     | bool          | �Ƿ��ǵ�һҳ   |
| hasnext     | bool          | �Ƿ�����һҳ |
| studentInfo | array[object] |                |
| studentId   | int           | ѧ��id         |
| studentName | string        | ѧ������       |

```json
{
   "retcode":0,
    "pagecount" : 1, 
    "recordcount" : 1, 
    "isfirst" : false, 
    "hasnext" : true, 
    "studentInfo":[
    	{
    	  "studentId":1,
    	  "studentName":"����",
    	},
    	{
    	  "studentId":2,
    	  "studentName":"����",
    	},
    	����
    ]
}
```

##### 1. ��ȡ����ѧ���ɼ�

```
http://api/workGrade?studnetId=1&courseId=1
```

������

| ������    | ���� | �Ƿ�ɿ� | ˵��   |
| --------- | ---- | -------- | ------ |
| studnetId | int  | ��       | ѧ��id |
| courseId  | int  | ��       | �γ�id |

���أ�

| �ֶ�      | ����          | ˵��                 |
| --------- | ------------- | -------------------- |
| retcode   | int           | ����ֵ               |
| name      | string        | ѧ������             |
| class     | string        | �༶                 |
| gender    | int           | �Ա�Ĭ��0�У�Ů1�� |
| gradeList | array[object] |                      |
| workName  | string        | ��ҵ����             |
| grade     | float         | �ɼ�                 |

```json
{
  "retcode":0,
  "name":"����",
  "class":"�༶",
  "gender":"�Ա�",
  "gradeList":[
   	  {
   		"workName":"��ҵ1",
   		"grade":"100"
   	  },
   	  ����
  ]
}
```

##### 2. ����ѧ���ɼ�

```
http://api/searchaworkGrade?keywords
```

������

| ������   | ����   | �Ƿ�ɿ� | ˵��   |
| -------- | ------ | -------- | ------ |
| keywords | string | ��       | �ؼ��� |

���أ�

| �ֶ�        | ����   | ˵��     |
| ----------- | ------ | -------- |
| retcode     | int    | ����ֵ   |
| studentList | array  | ѧ������ |
| studnetId   | int    | ѧ��id   |
| studentname | string | ����     |

```json
{
  "retcode":0,
  "studentList":[
   	  {
   		"studnetId":1,
   		"studentname":"����"
   	  },
      {
   		"studnetId":2,
   		"studentname":"����"
   	  },
   	  ����
  ]
}
```

#### 8.ʵ��ɼ�

#### 9.���Գɼ�

#### 10.�ɼ�����

```
http://api/gradeList?courseId=1
```

������

| ������   | ���� | �Ƿ�ɿ� | ˵��             |
| -------- | ---- | -------- | ---------------- |
| courseId | int  | ��       | �γ�id           |
| count    | int  | ��       | ÿҳ��¼����     |
| page     | int  | ��       | �ڼ�ҳ�� ��1��ʼ |

���أ�

| �ֶ�        | ����          | ˵��           |
| ----------- | ------------- | -------------- |
| retcode     | int           | ������         |
| pagecount   | int           | �����ܹ��м�ҳ |
| recordcount | int           | �ܹ���¼��     |
| isfirst     | bool          | �Ƿ��ǵ�һҳ   |
| hasnext     | bool          | �Ƿ�����һҳ |
| studentInfo | array[object] |                |
| studentId   | int           | ѧ��id         |
| studentName | string        | ѧ������       |

```json
{
   "retcode":0,
    "pagecount" : 1, 
    "recordcount" : 1, 
    "isfirst" : false, 
    "hasnext" : true, 
    "studentInfo":[
    	{
    	  "studentId":1,
    	  "studentName":"����",
    	},
    	{
    	  "studentId":2,
    	  "studentName":"����",
    	},
    	����
    ]
}
```

##### 1. ��ȡ����ѧ�����ܳɼ�

```
http://api/grade?studnetId=1&courseId=1
```

������

| ������    | ���� | �Ƿ�ɿ� | ˵��   |
| --------- | ---- | -------- | ------ |
| studnetId | int  | ��       | ѧ��id |
| courseId  | int  | ��       | �γ�id |

���أ�

| �ֶ�       | ����   | ˵��                 |
| ---------- | ------ | -------------------- |
| retcode    | int    | ����ֵ               |
| name       | string | ѧ������             |
| class      | string | �༶                 |
| gender     | int    | �Ա�Ĭ��0�У�Ů1�� |
| workgrade  | float  | ��ҵ�ɼ�             |
| labgrade   | float  | ʵ��ɼ�             |
| testgrade1 | float  | ���Գɼ�1            |
| testgrade2 | float  | ���Գɼ�2            |
| testgrade3 | float  | ���Գɼ�3            |
| testgrade4 | float  | ���Գɼ�4            |
| testgrade5 | float  | ���Գɼ�5            |
| finalgrade | float  | ���ճɼ�             |
| level      | string | �ȼ�                 |

```json
{
    "retcode":0,
    "name":"����",
    "class":"�༶",
    "gender":"�Ա�",
    "workgrade":"��ҵ�ɼ�",
    "labgrade":"ʵ��ɼ�",
    "testgrade1" :"100",
    "testgrade2" :"100",
    "testgrade3" :"100",
    "testgrade4" :"100",
    "testgrade5" :"100",
    "finalgrade" :"100",
    "level" :"�ȼ�"
}
```

#### 11.�Ծ��ӡ

```
http://api/printTest?courseId=1
```

������

| ������   | ���� | �Ƿ�ɿ� | ˵��   |
| -------- | ---- | -------- | ------ |
| courseId | int  | ��       | �γ�id |

���أ�

| �ֶ�        | ����          | ˵��           |
| ----------- | ------------- | -------------- |
| retcode     | int           | ������         |
| pagecount   | int           | �����ܹ��м�ҳ |
| recordcount | int           | �ܹ���¼��     |
| isfirst     | bool          | �Ƿ��ǵ�һҳ   |
| hasnext     | bool          | �Ƿ�����һҳ |
| printInfo   | array[object] |                |
| id          | int           | ��ӡ�Ծ�id     |
| name        | string        | ��ӡ�Ծ�����   |

```json
{
   "retcode":0,
    "pagecount" : 1, 
    "recordcount" : 1, 
    "isfirst" : false, 
    "hasnext" : true, 
    "printInfo":[
    	{
    	  "id":1,
    	  "name":"�Ծ�1",
    	},
    	{
    	  "id":2,
    	  "name":"�Ծ�2",
    	},
    	����
    ]
}
```

#####  1.��ȡ��ӡ������ϸ��Ϣ

```
http://api/getPrintInfo?courseId=1&id=1
```

������

| ������   | ���� | �Ƿ�ɿ� | ˵��       |
| -------- | ---- | -------- | ---------- |
| courseId | int  | ��       | �γ�id     |
| id       | int  | ��       | ��ӡ�Ծ�id |

���أ�

| �ֶ�      | ����          | ˵��     |
| --------- | ------------- | -------- |
| retcode   | int           | ������   |
|           | array[object] |          |
| count     | int           | ����     |
| startTime | string        | ��ʼʱ�� |
| endTime   | string        | ����ʱ�� |
| status    | string        | ״̬     |
| result    | string        | ���     |

```json
{
  "retcode":0,
  "printInfo":[
    {
      "count":1,
      "startTime":"��ʼʱ��",
      "endTime":"����ʱ��",
      "status":"״̬",
      "result":"���"
    }
  ]
}
```

##### 2. �½���ӡ

```
http://api/createdPrint?courseId=1
```

������

| ������    | ����          | �Ƿ�ɿ� | ˵��   |
| --------- | ------------- | -------- | ------ |
| courseId  | int           | ��       | �γ�id |
| printInfo | array[object] |          |        |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

##### 3. ������ӡ

```
http://api/resetPrint?id=1
```

������

| ������ | ���� | �Ƿ�ɿ� | ˵��       |
| ------ | ---- | -------- | ---------- |
| id     | int  | ��       | ��ӡ�Ծ�id |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json 
{
   "retcode":0
}
```

##### 4. ɾ����ӡ

```
http://api/deletePrint?id=1
```

������

| ������ | ���� | �Ƿ�ɿ� | ˵��       |
| ------ | ---- | -------- | ---------- |
| id     | int  | ��       | ��ӡ�Ծ�id |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json 
{
   "retcode":0
}
```





