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

���ز���˵����

| ������      | ����   | �Ƿ�ɿ� | ��ע                   |
| ----------- | ------ | -------- | ---------------------- |
| retcode     | ������ | ��       | ˵������               |
| authtoken   | string | ��       | �û���¼��ʶ����¼id�� |
| info        | object | ��       | ��������               |
| pagecount   | int    | ��       | ��ҳ����               |
| recordcount | int    | ��       | ����������             |
| isfirst     | bool   | ��       | �Ƿ��ǵ�һҳ           |
| hasnext     | bool   | ��       | �Ƿ�����һҳ           |
| items       | object | ��       |                        |
| debug       | string | ��       | ������Ϣ               |
| id          | int    | ��       | id                     |
| message     | string | ��       | ������Ϣ               |



```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {}
    ],
    "pagecount": 1,
    "recordcount": 10,
    "isfirst": true,
    "hasnext": true,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

���Թ��ߣ�postman��Ĭ������ʽ��get

### 1.��¼

```http 
http://localhost:5000/api/Launch/Login?username=&password=
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
| id        | int           | �û�id   |
| name      | string        | ����     |
| gender    | int           | �Ա�     |
| phone     | string        | �ֻ���   |
| qq        | string        | qq       |
| addr      | string        | ��ַ     |
| schoolId  | int           | ѧУId   |
| school    | string        | ѧУ     |

```json
{
    "retcode": 0,
    "authtoken": "97F02636E249793A37CED81599713373CF32DF9495F10BDD397063C90385D876",
    "info": {
        "id":"31308",
        "name": "����",
        "gender": null,
        "phone": null,
        "email": null,
        "qq": null,
        "addr": null,
        "schoolId": null,
        "school": null
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": "2020-04-20T02:12:39.0277858Z",
    "message": "��ʦ��¼�ɹ�"
}
```



### 2.�γ̼�����

#### 1.�γ�

##### 1.��ȡ�γ��б�



```http
http://localhost:5000/api/Course/GetCoursesList?authtoken=
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��     |
| --------- | ------ | -------- | -------- |
| authtoken | string | ��       | ��¼֤�� |

���أ�

| �ֶ�    | ����          | ˵��     |
| ------- | ------------- | -------- |
| retcode | int           | ������   |
| info    | array[object] |          |
| id      | int           | �γ�id   |
| name    | string        | �γ����� |
| intro   | string        | �γ̼�� |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 422,
            "name": "Java�������",
            "teacher": 31308,
            "teacher1": null,
            "teacher2": null,
            "teacher3": null,
            "intro": "<p>Java��һ�ּ򵥵ģ��������ġ��ֲ�ʽ�ġ����͵ġ���׳�ġ�����ֲ�ġ���������Ķ��̵߳Ķ�̬���ԡ�����������ѿ����չ�ͳ���׶Σ������Ѿ���Ϊ IT �����������������ԣ����ڶ�����õ��㷺��Ӧ�á����γ��Ծ�ҵΪ���򣬴Ӹ߼����˲�������Ҫ���������ǿ������Ӧ����������Ϊ���ߣ��������۽�ѧ��ϵ��ʵ����ѧ��ϵ��</p>",
            "createUserId": 6045,
            "createTime": "2019-04-16T13:46:19.087",
            "updateTime": "2019-04-16T13:46:19.087",
            "moduleKownledge": false,
            "moduleResource": false,
            "moduleHomework": false,
            "moduleMutualJudge": false,
            "moduleExperiment": false,
            "moduleSimulation": false,
            "moduleDiscuss": false,
            "logo1": null,
            "logoText": "Java�������",
            "logoBackgroundColor": "rgb(27, 161, 226)",
            "isDel": false,
            "isBan": false,
            "status": 0,
            "ord": null,
            "pzycj": 0.0,
            "psycj": 0.0,
            "pkscj1": 0.0,
            "pkscj2": 0.0,
            "pkscj3": 0.0,
            "pkscj4": 0.0,
            "pkscj5": 0.0,
            "isAuthor": false,
            "copyTimes": 0
        },
        {
            "id": 418,
            "name": "�߼��칫�Զ���������Ƶ��",
            "teacher": 31308,
            "teacher1": null,
            "teacher2": null,
            "teacher3": null,
            "intro": "�γ̼�飺����ѧ������������γ̣�32ѧʱ��2ѧ�֣�ͨʶ�γ̣���ѡ�Σ����ʺϷǼ����רҵѧ������Ҫ���ݣ�����˼ά��������һ����Ϣ������飻����ϵͳ��������ʹ�ã��칫�Զ�������ĸ߼����á��γ�Ŀ�꣺���ռ������ѧ�뼼���Ļ���֪ʶ���������ܣ����ѧ��Ӧ�ü�������ʵ�������������ע��˼ά������������Ϊѧ��������ѧϰ�춨�������ܹ����õ�ʹ�ü��������ؼ����������רҵ�������⡣",
            "createUserId": 5905,
            "createTime": "2019-04-16T13:03:52.493",
            "updateTime": "2019-04-16T13:03:52.493",
            "moduleKownledge": false,
            "moduleResource": false,
            "moduleHomework": false,
            "moduleMutualJudge": false,
            "moduleExperiment": false,
            "moduleSimulation": false,
            "moduleDiscuss": false,
            "logo1": null,
            "logoText": "�߼��칫�Զ���\r\n������Ƶ��",
            "logoBackgroundColor": "rgb(160, 80, 0)",
            "isDel": false,
            "isBan": null,
            "status": 0,
            "ord": null,
            "pzycj": 0.0,
            "psycj": 0.0,
            "pkscj1": 0.0,
            "pkscj2": 0.0,
            "pkscj3": 0.0,
            "pkscj4": 0.0,
            "pkscj5": 0.0,
            "isAuthor": false,
            "copyTimes": 0
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

#####  2.�����γ�

```http
http://localhost:5000/api/Course/GetCourse?authtoken=&id=422
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       |        |
| id        | int    | ��       | �γ�Id |

���أ�

| �ֶ�    | ����          | ˵��     |
| ------- | ------------- | -------- |
| retcode | int           | ������   |
| info    | array[object] |          |
| id      | int           | �γ�id   |
| name    | string        | �γ����� |
| intro   | string        | �γ̼�� |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 422,
            "name": "Java�������",
            "teacher": 31308,
            "teacher1": null,
            "teacher2": null,
            "teacher3": null,
            "intro": "<p>Java��һ�ּ򵥵ģ��������ġ��ֲ�ʽ�ġ����͵ġ���׳�ġ�����ֲ�ġ���������Ķ��̵߳Ķ�̬���ԡ�����������ѿ����չ�ͳ���׶Σ������Ѿ���Ϊ IT �����������������ԣ����ڶ�����õ��㷺��Ӧ�á����γ��Ծ�ҵΪ���򣬴Ӹ߼����˲�������Ҫ���������ǿ������Ӧ����������Ϊ���ߣ��������۽�ѧ��ϵ��ʵ����ѧ��ϵ��</p>",
            "createUserId": 6045,
            "createTime": "2019-04-16T13:46:19.087",
            "updateTime": "2019-04-16T13:46:19.087",
            "moduleKownledge": false,
            "moduleResource": false,
            "moduleHomework": false,
            "moduleMutualJudge": false,
            "moduleExperiment": false,
            "moduleSimulation": false,
            "moduleDiscuss": false,
            "logo1": null,
            "logoText": "Java�������",
            "logoBackgroundColor": "rgb(27, 161, 226)",
            "isDel": false,
            "isBan": false,
            "status": 0,
            "ord": null,
            "pzycj": 0.0,
            "psycj": 0.0,
            "pkscj1": 0.0,
            "pkscj2": 0.0,
            "pkscj3": 0.0,
            "pkscj4": 0.0,
            "pkscj5": 0.0,
            "isAuthor": false,
            "copyTimes": 0
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```



#### 2.ѧ��

##### 1.ѧ���б�������

```http
http://localhost:5000/api/Users/StudentList?authtoken=&courseId=422&keyword&page=1&count=10
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��     |
| --------- | ------ | -------- | -------- |
| authtoken | string | ��       | ����     |
| courseId  | int    | ��       | �γ�Id   |
| keyword   | string | ��       | �ؼ���   |
| page      | int    | ��       | ҳ��     |
| count     | int    | ��       | ÿҳ���� |

���أ�

| �ֶ�     | ����          | ˵��   |
| -------- | ------------- | ------ |
| retcode  | int           | ������ |
| info     | array[object] |        |
| id       | int           | ѧ��id |
| userName | string        | ����   |
| userNO   | string        | ѧ��   |
| realName | string        | ����   |
| sex      | string        | �Ա�   |
| mobile   | string        | �ֻ��� |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 20518,
            "userName": "2015210402004",
            "userNO": "2015210402004",
            "realName": "��ܲ��",
            "sex": "",
            "userIdentity02": null,
            "mobile": null
        },
        {
            "id": 20519,
            "userName": "2015210402020",
            "userNO": "2015210402020",
            "realName": "����",
            "sex": "",
            "userIdentity02": null,
            "mobile": null
        },
        {
            "id": 20543,
            "userName": "2015210405064",
            "userNO": "2015210405064",
            "realName": "��ΰ��",
            "sex": "",
            "userIdentity02": null,
            "mobile": null
        },
        {
            "id": 29686,
            "userName": "1",
            "userNO": "1",
            "realName": "1",
            "sex": "��",
            "userIdentity02": null,
            "mobile": "����"
        },
        {
            "id": 29687,
            "userName": "2",
            "userNO": "2",
            "realName": "2",
            "sex": null,
            "userIdentity02": null,
            "mobile": null
        },
        {
            "id": 31312,
            "userName": "1008601",
            "userNO": null,
            "realName": "����",
            "sex": "��",
            "userIdentity02": null,
            "mobile": null
        }
    ],
    "pagecount": 1,
    "recordcount": 6,
    "isfirst": true,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2.ѧ������

```http 
http://localhost:5000/api/Users/GetStudent?id=29687
```

������

| ������ | ���� | �Ƿ�ɿ� | ˵��   |
| ------ | ---- | -------- | ------ |
| id     | int  | ��       | ѧ��id |

����:

| �ֶ�           | ����          | ˵��    |
| -------------- | ------------- | ------- |
| retcode        | int           | ������  |
| info           | array[object] |         |
| id             | int           | id      |
| userName       | string        | �˺�    |
| userNO         | string        | ѧ��    |
| realName       | string        | ����    |
| sex            | string        | �Ա�    |
| userIdentity02 | string        | �༶    |
| mobile         | string        | �绰    |
| userIdentity00 | string        | ѧԺ/ϵ |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "id": 29687,
        "userName": "2",
        "userNO": "2",
        "realName": "2",
        "sex": null,
        "userIdentity02": null,
        "mobile": null,
        "userIdentity00":null
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2.���ѧ��

[post]

```http 
http://api/Users/AddCourseStudent?authtoken=&courseId=422
```

������

| ������         | ����          | �Ƿ�ɿ� | ˵��                   |
| -------------- | ------------- | -------- | ---------------------- |
| authtoken      | string        | ��       | ����                   |
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
http://api/Users/EditUser?authtoken=&id=35899
```

   [HttpPatch]

�й�HttpPatch�ֲ����²���ת��������ӣ�

```json 
https://www.cnblogs.com/bijinshan/p/9140111.html
```

���� params��

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| id        | int    | ��       | ѧ��id |

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

```http
http://api/DeleteUser?id=
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

```http
http://api/RetsetPwd?authtoken=&id
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| id        | int    | ��       | ѧ��id |

���أ�

```
{
  "retcode" : 0
}
```





#### 3.��ҵ��ʵ�顢��ϰ

##### 1. �б�������

```http
http://localhost:5000/api/Course/HomeWorkList?authtoken=&courseId=422&type=3&keyword&page=1&count=10
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��                    |
| --------- | ------ | -------- | ----------------------- |
| authtoken | string | ��       | ����                    |
| courseId  | int    | ��       | �γ�id                  |
| type      | int    | ��       | 1���� 2��ϰ 3��ҵ 4ʵ�� |
| keyword   | string | ��       | �ؼ���                  |
| page      | int    | ��       | ҳ��                    |
| count     | int    | ��       | ÿҳ����                |

���أ�

| �ֶ�        | ����          | ˵��     |
| ----------- | ------------- | -------- |
| retcode     | int           | ������   |
| info        | array[object] |          |
| id          | int           | ��ҵid   |
| name        | string        | ��ҵ���� |
| pagecount   |               |          |
| recordcount |               |          |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "nid": "73fed0602562cb1e",
            "name": "Java�������-��ҵʮ��",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-12-14T00:00:00",
            "endTime": "2018-12-22T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 2095,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "nid": "d53660f85ca2db1e",
            "name": "Java�������-��ҵʮһ",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-12-07T00:00:00",
            "endTime": "2018-12-13T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 2085,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "nid": "27adec3f3f88af1e",
            "name": "Java�������-��ҵʮ",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-11-30T00:00:00",
            "endTime": "2018-12-05T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 2055,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "nid": "3e54754d19e34b1e",
            "name": "Java�������-��ҵ�� ",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-11-22T00:00:00",
            "endTime": "2018-11-29T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 2035,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "nid": "c304e3f9dd02cb1e",
            "name": "Java�������-��ҵ��",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-11-16T00:00:00",
            "endTime": "2018-11-22T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 2009,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "nid": "18a90f31862cb1e",
            "name": "Java�������-��ҵ��",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-11-02T00:00:00",
            "endTime": "2018-11-14T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 1949,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "nid": "eff935b78243cb1e",
            "name": "Java�������-��ҵ��",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-10-19T00:00:00",
            "endTime": "2018-10-26T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 1911,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "nid": "933b7bd255decb1e",
            "name": "Java�������-��ҵ��",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-10-11T00:00:00",
            "endTime": "2018-10-17T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 1875,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "nid": "95ccda2b75515b1e",
            "name": "Java�������-��ҵ��",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-09-30T00:00:00",
            "endTime": "2018-10-11T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 1821,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "nid": "e7419f115b06cb1e",
            "name": "Java�������-��ҵ��",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-09-28T00:00:00",
            "endTime": "2018-10-10T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 1819,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        }
    ],
    "pagecount": 2,
    "recordcount": 12,
    "isfirst": true,
    "hasnext": true,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2. �������

```http
http://localhost:5000/api/Course/DrawPlotList?authtoken=
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��         |
| --------- | ------ | -------- | ------------ |
| authtoken | string | ��       | �û���¼���� |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{
    "retcode": 0,
    "authtoken": "97F02636E249793AACC3EA72B75A5BE5510CBACC45C9E2D447392798BBDE50D6",
    "info": [
        {
            "id": 2399,
            "name": "C���Գ������"
        },
        {
            "id": 2400,
            "name": "����������ֹ����"
        },
        {
            "id": 2409,
            "name": "C�����ֹ����2"
        },
        {
            "id": 2410,
            "name": "C���Բ��Բ���"
        },
        {
            "id": 2427,
            "name": "test"
        },
        {
            "id": 2437,
            "name": "new����"
        },
        {
            "id": 2458,
            "name": "����A"
        },
        {
            "id": 2459,
            "name": "new"
        },
        {
            "id": 2467,
            "name": "1"
        },
        {
            "id": 2484,
            "name": "new"
        },
        {
            "id": 2570,
            "name": "����0729"
        },
        {
            "id": 2580,
            "name": "����"
        },
        {
            "id": 2401,
            "name": "C����֪ʶ�����"
        },
        {
            "id": 2583,
            "name": "test "
        },
        {
            "id": 2586,
            "name": "11"
        },
        {
            "id": 2710,
            "name": "����"
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```



##### 3. ���

[post]

```http
http://api/course/AddHomeWork?authtoken=&courseId=422&type=3
```

������

| ������                  | ����          | �Ƿ�ɿ� | ˵��                              |
| ----------------------- | ------------- | -------- | --------------------------------- |
| authtoken               | string        | ��       | �û���¼����                      |
| courseId                | int           | ��       | �γ�id                            |
| type                    | int           | ��       | 1���� ��2��ϰ ��3��ҵ��4ʵ��      |
| test                    | array[object] |          |                                   |
| name                    | string        | ��       | ����                              |
| drawPlotId              | int           | ��       | �������Id                        |
| startTime               | DateTime      | ��       | ��ʼʱ��                          |
| endTime                 | DateTime      | ��       | ����ʱ��                          |
| delayEndTime            | DateTime      | ��       | ������ֹʱ��                      |
| delayPercentOfScore     | double        | ��       | �����÷ֱ���                      |
| memo                    | string        | ��       | ˵��                              |
| enableMutualJudge       | bool          | ��       | ��ҵ������Ĭ��0,��������1�������� |
| mutualJudgeEndTime      | DateTime      | ��       | ������ֹʱ��                      |
| setScore                | double        | ��       | ����չʾ                          |
| scoreAppear             | int           | ��       | �ɼ�չʾ                          |
| forbiddenCopy           | bool          | ��       | ��ֹ������Ŀ                      |
| forbiddenMouseRightMenu | bool          | ��       | ��ֹ�Ҽ�                          |
| enableClientJudge       | bool          | ��       | ����ѧ�����ľ�                    |
| keyVisible              | bool          | ��       | ���ʱ��׼�𰸿ɼ�                |

���͸�ʽ��Body+raw+Json

```json
	{
		"name":"����",
		"drawPlotId":2710,
		"startTime":"2020-04-20 00:00:00.000",
		"endTime":"2020-04-21 23:59:00.000",
		"delayEndTime":"",
		"delayPercentOfScore":"",
		"memo":"",
		"enableMutualJudge":"",
		"mutualJudgeEndTime":"",
		"setScore":100,
		"scoreAppear":1,
		"forbiddenCopy":1,
		"forbiddenMouseRightMenu":1,
		"enableClientJudge":1,
		"keyVisible":1,
	}
```

���أ�

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
    "message": "�����ɹ�"
}
```

##### 2. �༭(����)

[HttpPatch]

```http
http://localhost:5000/api/Course/EditHomeWork?authtoken=&id=6699
```

  ���� params��

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| id        | int    | ��       | ��ҵid |

Headers ��

| key          | value                       |
| ------------ | --------------------------- |
| Content-Type | application/json-patch+json |

Body: 

```json
[
	{
		"op":"replace",
		"path":"/name",
		"value":"Java�������-��ҵһ����"
	},
	{
		"op":"replace",
		"path":"/EndTime",
		"value":"2019-12-22"
	},
    {
        ����
    }
]
```

 ���أ�

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

##### 3. ɾ��

```http
http://localhost:5000/api/Course/DeleteWork?authtoken=&id=9827
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵�� |
| --------- | ------ | -------- | ---- |
| authtoken | string | ��       | ���� |
| id        | int    | ��       | id   |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

#####  4. ����

��ô��ľ��ѧ����ҵ��ʵ����Ϣ�б�

```http 
http://localhost:5000/api/Course/JudgeList?authtoken=&testId=6699
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��               |
| --------- | ------ | -------- | ------------------ |
| authtoken | string | ��       | ����               |
| testId    | int    | ��       | ��ҵ��ʵ�顢��ϰId |

���أ�

| �ֶ�                | ����          | ˵��                     |
| ------------------- | ------------- | ------------------------ |
| retcode             | int           | ������                   |
| info                | array[object] |                          |
| id                  | int           | id                       |
| userTestNo          | string        | ѧ��                     |
| userTrueName        | string        | ѧ������                 |
| logonIp             | string        | ��¼IP                   |
| submitTime          | DateTime      | �ύʱ�䣨null��δ���� |
| finishQuestionCount | int           | ������                   |
| totalScore          | double        | �ܷ�                     |
| score               | double        | �÷�                     |
| status              | bool          | ״̬���Ƿ��ľ�         |

```json
{  
 	retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 317220,
            "userTestNo": "2015210405064",
            "userTrueName": "��ΰ��",
            "logonIp": "172.22.124.95",
            "submitTime": null,
            "finishQuestionCount": 0,
            "totalScore": 40.0,
            "score": 0.0,
            "status": true
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

#### 4.�γ���Դ

##### 1. ��ȡ��Դ�б�������

```http
http://localhost:5000/api/Course/ResourceList?authtoken=&courseId=422&parentId=0
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��             |
| --------- | ------ | -------- | ---------------- |
| authtoken | string | ��       | ����             |
| courseId  | int    | ��       | �γ�id           |
| parentId  | int    | ��       | ��Դ���ӹ�����ʶ |
| keyword   | string | ��       | �ؼ���           |

���أ�

| �ֶ�       | ����          | ˵��         |
| ---------- | ------------- | ------------ |
| retcode    | int           | ������       |
| info       | array[object] |              |
| id         | int           | �ļ�id       |
| parentId   | int           | ���ӹ�����ʶ |
| fileName   | string        | �ļ���       |
| fileIcon   | string        | �ļ�ͼ��     |
| url        | string        | URL�ļ�·��  |
| fileType   | string        | �ļ�����     |
| size       | string        | �ļ���С     |
| isDir      | bool          | �Ƿ�ѹ��     |
| isDel      | bool          | �Ƿ�ɾ��     |
| isShared   | bool          | �Ƿ���     |
| createTime | string        | �ļ��������� |
| userId     | int           | ������id     |
| password   | string        | ����         |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 2174,
            "parentId": 0,
            "fileName": "WayBackIntoLove.mp3",
            "fileIcon": "music",
            "url": "~/Upload/resource/422/7a25ed6a-5be5-4df4-94a3-ab97006d1fab.mp3",
            "fileType": "mp3",
            "size": 11658607.0,
            "isDir": false,
            "isDel": false,
            "isShared": false,
            "createTime": "2020-04-08T14:37:18.473",
            "userId": 31308,
            "password": null
        },
        ����
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2. �ϴ��ļ���δ����

```http
http://api/upFile?authtoken=&courseId=1
```

������

| ������    | ����          | �Ƿ�ɿ� | ˵��         |
| --------- | ------------- | -------- | ------------ |
| authtoken | string        | ��       | ����         |
| courseId  | int           | ��       | �γ�id       |
| fileData  | array[object] | ��       | �����ļ���Ϣ |

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

```http
http://api/Course/DeleteResource?authtoken=&id=1
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| id        | int    | ��       | ��Դid |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0
}
```

##### 4.�ļ�������

```http
http://api/Course/Rename?authtoken=&id=1961&name=
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| id        | int    | ��       | ��Դid |
| name      | string | ��       | ������ |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json
{  
 	"retcode" : 0,
    "message" = "�������ɹ�"
}
```

#### 5.�ɼ�

##### 1.��ҵ,ʵ��,���Գɼ�

�Ȼ�ȡ�γ��µ�ѧ���б���ѧ���б��������ٸ���ѧ��id��ȡ�ɼ�

```http
http://localhost:5000/api/Course/ScoreInfo?authtoken=&courseId=422&type=3&userId=20518
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| courseId  | int    | ��       | �γ�id |
| type      | int    | ��       | ����   |
| userId    | int    | ��       | ѧ��id |

���أ�

| �ֶ�                 | ����          | ˵��   |
| -------------------- | ------------- | ------ |
| retcode              | int           | ������ |
| info                 | Array[object] |        |
| ��ҵ��ʵ�飬�������� | ����          |        |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "java�������-��ҵһ": "0",
        "java�������-��ҵ��": "0",
        "java�������-��ҵ��": "0",
        "java�������-��ҵ��": "0",
        "java�������-��ҵ��": "0",
        "java�������-��ҵ��": "0",
        "java�������-��ҵ��": "0",
        "java�������-��ҵ��": "0",
        "java�������-��ҵ�� ": "0",
        "java�������-��ҵʮ": "0",
        "java�������-��ҵʮһ": "0",
        "java�������-��ҵʮ��": "0",
        "����": "0"
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2.�ɼ�����

```http
http://localhost:5000/api/Course/StudentGrade?authtoken=&courseId=422&id=20518
```

�Ȼ�ȡ�γ��µ�ѧ���б���ѧ���б��������ٸ���ѧ��id��ȡ�ɼ�����

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| courseId  | int    | ��       | �γ�id |
| Id        | int    | ��       | ѧ��id |

���أ�

| �ֶ�       | ����          | ˵��      |
| ---------- | ------------- | --------- |
| retcode    | int           | ����ֵ    |
| info       | array[object] |           |
| courseId   | int           | �γ�id    |
| userId     | int           | ѧ��id    |
| zycj       | double        | ��ҵ�ɼ�  |
| sycj       | double        | ʵ��ɼ�  |
| kscj1      | double        | ���Գɼ�1 |
| kscj2      | double        | ���Գɼ�2 |
| kscj3      | double        | ���Գɼ�3 |
| kscj4      | double        | ���Գɼ�4 |
| kscj5      | double        | ���Գɼ�5 |
| cj         | double        | �ɼ�      |
| finalGrade | double        | ���ճɼ�  |
| level      | string        | �ȼ�      |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "courseId": 422,
            "userId": 20518,
            "zycj": 0.0,
            "sycj": 0.0,
            "kscj1": 0.0,
            "kscj2": 0.0,
            "kscj3": 0.0,
            "kscj4": 0.0,
            "kscj5": 0.0,
            "cj": 0.0,
            "course": null,
            "finalGrade": 0.0,
            "level": "����"
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

#### 6.�Ծ��ӡ

#####  1.��ӡ�����б�������

```http
http://localhost:5000/api/Course/PaperTaskList?authtoken=&courseId=422&authtoken=&keyword
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��         |
| --------- | ------ | -------- | ------------ |
| authtoken | string | ��       | ����         |
| courseId  | int    | ��       | �γ�id       |
| authtoken | string | ��       | ��¼�û����� |
| keyword   | string | ��       | �ؼ���       |

���أ�

| �ֶ�        | ����          | ˵��     |
| ----------- | ------------- | -------- |
| retcode     | int           | ������   |
| info        | array[object] |          |
| id          | int           | id       |
| name        | string        | ����     |
| totalCount  | int           | �Ծ����� |
| finishCount | int           | �����   |
| startTime   | string        | ��ʼʱ�� |
| finishTime  | DateTime      | ���ʱ�� |
| fileName    | string        | �ļ����� |
| filePath    | string        | ·��     |
| result      | string        | ״̬     |
| message     | string        | ���     |
| fileSize    | string        | �ļ���С |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 671,
            "name": "Java�������-��ҵʮ���Ծ��ӡ����",
            "totalCount": 1,
            "finishCount": 1,
            "startTime": "2020-04-10T20:22:28.003",
            "finishTime": "2020-04-10T20:22:30.023",
            "fileName": "e4165150e8525c02.zip",
            "filePath": "E:\\webiste\\XTest\\output\\paper\\zip\\e4165150e8525c02.zip",
            "result": "�ɹ�",
            "message": null,
            "fileSize": "62.09 KB"
        },
        {
            "id": 669,
            "name": "Java�������-ʵ��ʮ�Ծ��ӡ����",
            "totalCount": 0,
            "finishCount": 0,
            "startTime": "2020-04-13T17:49:57.48",
            "finishTime": "2020-04-13T17:49:57.62",
            "fileName": "8933448d4d336044.zip",
            "filePath": "E:\\webiste\\XTest\\output\\paper\\zip\\8933448d4d336044.zip",
            "result": "�ɹ�",
            "message": "",
            "fileSize": "22.00 �ֽ�"
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2. ��ӡ������ѡ��

```http
http://localhost:5000/api/Course/ChooseTest?authtoken=&courseId=422
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| courseId  | int    | ��       | �γ�id |

���أ�

| �ֶ�    | ����          | ˵��   |
| ------- | ------------- | ------ |
| retcode | int           | ������ |
| info    | array[object] |        |
| id      | int           | id     |
| name    | string        | ����   |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 9828,
            "name": "����"
        },
        {
            "id": 6676,
            "name": "Java�������-��ҵʮ��"
        },
        {
            "id": 6678,
            "name": "Java�������-��ҵʮһ"
        },
        {
            "id": 6681,
            "name": "Java�������-��ҵʮ"
        },
        {
            "id": 6682,
            "name": "Java�������-��ҵ�� "
        },
        {
            "id": 6685,
            "name": "Java�������-��ҵ��"
        },
        {
            "id": 6687,
            "name": "Java�������-��ҵ��"
        },
        {
            "id": 6689,
            "name": "Java�������-��ҵ��"
        },
        {
            "id": 6691,
            "name": "Java�������-��ҵ��"
        },
        {
            "id": 6694,
            "name": "Java�������-��ҵ��"
        },
        {
            "id": 6695,
            "name": "Java�������-��ҵ��"
        },
        {
            "id": 6697,
            "name": "Java�������-��ҵ��"
        },
        {
            "id": 6699,
            "name": "Java�������-��ҵһ����"
        },
        {
            "id": 6677,
            "name": "Java�������-ʵ��ʮ��"
        },
        {
            "id": 6679,
            "name": "Java�������-ʵ��ʮһ"
        },
        {
            "id": 6680,
            "name": "Java�������-ʵ��ʮ"
        },
        {
            "id": 6683,
            "name": "Java�������-ʵ���"
        },
        {
            "id": 6684,
            "name": "Java�������-ʵ���"
        },
        {
            "id": 6686,
            "name": "Java�������-ʵ����"
        },
        {
            "id": 6688,
            "name": "Java�������-ʵ����"
        },
        {
            "id": 6690,
            "name": "Java�������-ʵ����"
        },
        {
            "id": 6692,
            "name": "Java�������-ʵ����"
        },
        {
            "id": 6693,
            "name": "Java�������-ʵ����"
        },
        {
            "id": 6696,
            "name": "Java�������-ʵ���"
        },
        {
            "id": 6698,
            "name": "Java�������-ʵ��һ"
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 3.��Ӵ�ӡ����

[post]

```http
http://localhost:5000/api/Course/AddPaperTask?authtoken=&courseId=422&authtoken=&testId=9828
```

| ������    | ����          | �Ƿ�ɿ� | ˵��               |
| --------- | ------------- | -------- | ------------------ |
| authtoken | string        | ��       | ����               |
| courseId  | int           | ��       | �γ�Id             |
| authtoken | string        | ��       | �û���¼����       |
| testId    | int           | ��       | ��ӡ������ѡ��Id |
| pePaper   | array[object] |          |                    |
| option2   | string        | ��       | ������             |

���͸�ʽ��Body+raw+Json

```json
{
	"option2":"test"
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
    "message": "��ӳɹ�"
}
```



##### 4. ������ӡ��δ����

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

##### 5. ɾ����ӡ

```http
http://localhost:5000/api/Course/DeletePaperTask?authtoken=&id=1
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��       |
| --------- | ------ | -------- | ---------- |
| authtoken | string | ��       | ����       |
| id        | int    | ��       | ��ӡ�Ծ�id |

���أ�

| �ֶ�    | ���� | ˵��   |
| ------- | ---- | ------ |
| retcode | int  | ������ |

```json 
{
   "retcode":0,
    "message":"ɾ���ɹ�"
}
```





