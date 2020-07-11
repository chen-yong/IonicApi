

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

| ������   | ����   | �Ƿ�ɿ� | ��ע | PE-User��                         |
| -------- | ------ | -------- | ---- | --------------------------------- |
| username | string | ��       | �˺� | UserName��Email����ʵһ���͹��ˣ� |
| password | string | ��       | ���� | Password                          |

���أ�

| �ֶ�      | ����          | ˵��     |            |
| --------- | ------------- | -------- | ---------- |
| retcode   | int           | ������   |            |
| authtoken | string        | ��¼֤�� |            |
| info      | array[object] |          | PE-User��  |
| id        | int           | �û�id   | Id         |
| name      | string        | ����     | RealName   |
| gender    | int           | �Ա�     | Sex        |
| phone     | string        | �ֻ���   | Mobile     |
| qq        | string        | qq       | Property05 |
| addr      | string        | ��ַ     | Address    |
| schoolId  | int           | ѧУId   | SchoolId   |
| school    | string        | ѧУ     | School     |

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

##### 1.��ȡ��ʦ�γ��б�



```http
http://localhost:5000/api/Course/GetCoursesList?authtoken=
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��     |
| --------- | ------ | -------- | -------- |
| authtoken | string | ��       | ��¼֤�� |

���أ�

| �ֶ�    | ����          | ˵��                          |
| ------- | ------------- | ----------------------------- |
| retcode | int           | ������                        |
| info    | array[object] | ����ӦPE-Course���ֶ�ͬ���� |
| id      | int           | �γ�id                        |
| name    | string        | �γ�����                      |
| intro   | string        | �γ̼��                      |

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

##### 1.2��ȡѧ�����μӵ����пγ�

[get]����

```http
http://localhost:5000/api/Course/GetCourseByStudent?authtoken=&userId=29991
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��         |
| --------- | ------ | -------- | ------------ |
| authtoken | string | ��       | ��¼֤��     |
| userId    | int    | ��       | ѧ�����û�id |

���أ�

| �ֶ�    | ����          | ˵��                          |
| ------- | ------------- | ----------------------------- |
| retcode | int           | ������                        |
| info    | array[object] | ����ӦPE-Course���ֶ�ͬ���� |
| id      | int           | �γ�id                        |
| name    | string        | �γ�����                      |
| intro   | string        | �γ̼��                      |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 562,
            "name": "��ѧ���������-������2019-2020-2",
            "teacher": 5906,
            "teacher1": null,
            "teacher2": null,
            "teacher3": null,
            "intro": "�γ̼�飺����ѧ������������γ̣�32ѧʱ��2ѧ�֣�ͨʶ�γ̣���ѡ�Σ����ʺϷǼ����רҵѧ������Ҫ���ݣ��������������һ����Ϣ������飻����ϵͳ��������ʹ�ã��칫�Զ�������ĸ߼����á��γ�Ŀ�꣺���ռ������ѧ�뼼���Ļ���֪ʶ���������ܣ����ѧ��Ӧ�ü�������ʵ�������������ע��˼ά������������Ϊѧ��������ѧϰ�춨�������ܹ����õ�ʹ�ü��������ؼ����������רҵ�������⡣",
            "createUserId": 5905,
            "createTime": "2020-02-18T14:20:56.947",
            "updateTime": "2020-02-18T14:21:55.57",
            "moduleKownledge": false,
            "moduleResource": false,
            "moduleHomework": false,
            "moduleMutualJudge": false,
            "moduleExperiment": false,
            "moduleSimulation": false,
            "moduleDiscuss": false,
            "logo1": "",
            "logoText": "��ѧ���������-������2019-2020-2",
            "logoBackgroundColor": "rgb(27, 161, 226)",
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
            "isAuthor": true,
            "copyTimes": 0
        },
        {
            "id": 348,
            "name": "����ѧԺ����",
            "teacher": 25086,
            "teacher1": null,
            "teacher2": null,
            "teacher3": null,
            "intro": null,
            "createUserId": 25086,
            "createTime": "2018-11-07T19:12:08.923",
            "updateTime": "2018-11-07T19:20:25.803",
            "moduleKownledge": false,
            "moduleResource": false,
            "moduleHomework": false,
            "moduleMutualJudge": false,
            "moduleExperiment": false,
            "moduleSimulation": false,
            "moduleDiscuss": false,
            "logo1": "",
            "logoText": "����ѧԺ����",
            "logoBackgroundColor": "rgb(27, 161, 226)",
            "isDel": false,
            "isBan": null,
            "status": 0,
            "ord": null,
            "pzycj": 50.0,
            "psycj": 0.0,
            "pkscj1": 0.0,
            "pkscj2": 50.0,
            "pkscj3": 0.0,
            "pkscj4": 0.0,
            "pkscj5": 0.0,
            "isAuthor": true,
            "copyTimes": 1
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
    "message": "�ɹ���ȡѧ����������пγ���Ϣ"
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

| �ֶ�    | ����          | ˵��                          |
| ------- | ------------- | ----------------------------- |
| retcode | int           | ������                        |
| info    | array[object] | ����ӦPE-Course���ֶ�ͬ���� |
| id      | int           | �γ�id                        |
| name    | string        | �γ�����                      |
| intro   | string        | �γ̼��                      |

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

| ������    | ����   | �Ƿ�ɿ� | ˵��                                   |
| --------- | ------ | -------- | -------------------------------------- |
| authtoken | string | ��       | ����                                   |
| courseId  | int    | ��       | �γ�Id��PE_CourseStudent�е�CourseId�� |
| keyword   | string | ��       | �ؼ���                                 |
| page      | int    | ��       | ҳ��                                   |
| count     | int    | ��       | ÿҳ����                               |

���أ�

| �ֶ�     | ����          | ˵��                          |
| -------- | ------------- | ----------------------------- |
| retcode  | int           | ������                        |
| info     | array[object] | PE_User���ݱ��ж�Ӧ��ͬ���ֶ� |
| id       | int           | ѧ��id                        |
| userName | string        | ����                          |
| userNO   | string        | ѧ��                          |
| realName | string        | ����                          |
| sex      | string        | �Ա�                          |
| mobile   | string        | �ֻ���                        |

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
http://localhost:5000/api/Users/GetStudent?authtoken=&id=29687
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��                        |
| --------- | ------ | -------- | --------------------------- |
| authtoken | string | ��       | ����                        |
| id        | int    | ��       | ѧ��id��PE_User���ݱ���Id�� |

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

##### 2�û�����

[get]

```http 
http://localhost:5000/api/Users/GetUserByAuthtoken?authtoken=
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵�� |      |
| --------- | ------ | -------- | ---- | ---- |
| authtoken | string | ��       | ���� |      |

����:

| ������      | ����   | �Ƿ�ɿ� | ��ע                                    |
| ----------- | ------ | -------- | --------------------------------------- |
| retcode     | ������ | ��       | ˵������                                |
| authtoken   | string | ��       | �û���¼��ʶ����¼id��                  |
| info        | object | ��       | ��������(PE_User���ݱ��ж�Ӧ��ͬ���ֶ�) |
| pagecount   | int    | ��       | ��ҳ����                                |
| recordcount | int    | ��       | ����������                              |
| isfirst     | bool   | ��       | �Ƿ��ǵ�һҳ                            |
| hasnext     | bool   | ��       | �Ƿ�����һҳ                            |
| items       | object | ��       |                                         |
| debug       | string | ��       | ������Ϣ                                |
| id          | int    | ��       | id                                      |
| message     | string | ��       | ������Ϣ                                |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "id": 31308,
        "userName": "chenyong",
        "userNO": "2018112011006",
        "password": "E10ADC3949BA59ABBE56E057F20F883E",
        "realName": "����",
        "sex": "��",
        "brithday": "0001-01-01T00:00:00",
        "email": "10086@gmail",
        "mobile": "0571-28865731",
        "userIdentity00": null,
        "userIdentity01": "1",
        "userIdentity02": null,
        "userIdentity03": "2",
        "zip": null,
        "address": "����ʦ����ѧ��ǰУ��",
        "avatar": null,
        "introduction": null,
        "property00": null,
        "property01": null,
        "property02": null,
        "property03": null,
        "property04": null,
        "property05": "10086",
        "property06": "641AA374F3CFB9FB28A9A2CBFFB9CA3F",
        "property07": null,
        "property08": null,
        "property09": null,
        "schoolId": "5453742274816630924",
        "school": null
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

##### 

##### 2.���ѧ��

[post]

```http 
http://api/Users/AddCourseStudent?authtoken=&courseId=422
```

������

| ������         | ����          | �Ƿ�ɿ� | ˵��                                                        |
| -------------- | ------------- | -------- | ----------------------------------------------------------- |
| authtoken      | string        | ��       | ����                                                        |
| courseId       | int           | ��       | �γ�id                                                      |
| addUser        | array[object] |          | ��username��PE_User�����ж��û��Ƿ���ڣ���������������û� |
| userName       | string        | ��       | �˺�                                                        |
| realName       | string        | ��       | ��ʵ����                                                    |
| userIdentity00 | string        | ��       | ѧԺ��ϵ                                                    |
| property02     | string        | ��       | �༶                                                        |
| sex            | string        | ��       | �Ա��У�Ů��Ĭ���У�                                      |
| mobile         | string        | ��       | �绰                                                        |

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

##### 3.2�༭�û�������Ϣ������userName����Ҫ�У�

```http
http://localhost:5000/api/Users/EditAdmin?authtoken=&id=1
```

   [HttpPost]���Ժ����ȫ����post��

���� params��

| ������    | ����   | �Ƿ�ɿ� | ˵��                     |
| --------- | ------ | -------- | ------------------------ |
| authtoken | string | ��       | ����                     |
| id        | int    | ��       | ѧ��id ��PE_User�е�id�� |

Headers ��

| key          | value                     |
| ------------ | ------------------------- |
| Content-Type | application/Body+raw+Json |

Body: 

```json
{
    "userName": "yhj",
    "sex": "��",
    "mobile": "28865371",
    "email": "1033552@gmail",
    "address": "��ʦ��",
    "property05": "1033558982"
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
    "message": "�û��޸ĳɹ�"
}
```



##### 4.ɾ��ѧ��

```http
http://api/Users/DeleteUser?authtoken=&id=
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵������ɾ������PE_User�ж�Ӧ�û���UserIdentity01��Ϊ0�� |
| --------- | ------ | -------- | -------------------------------------------------------- |
| authtoken | string | ��       | ����                                                     |
| id        | int    | ��       | ѧ��id��PE_User�е�id��                                  |

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

[get]

```http
http://api/Users/RetsetPwd?authtoken=&id
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��                    |
| --------- | ------ | -------- | ----------------------- |
| authtoken | string | ��       | ����                    |
| id        | int    | ��       | ѧ��id��PE_User�е�id�� |

���أ�

```
{
  "retcode" : 0
}
```

##### 5.2 �޸ĸ�������

[post]

```http
http://localhost:5000/api/Users/EditPwd?authtoken=&id=31308
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��                    |
| --------- | ------ | -------- | ----------------------- |
| authtoken | string | ��       | ����                    |
| id        | int    | ��       | ѧ��id��PE_User�е�id�� |

Headers ��

| key          | value                     |
| ------------ | ------------------------- |
| Content-Type | application/Body+raw+Json |

Body: 

```json
{
    "password": "123456"
}

```

����:

```
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
    "message": "�����޸ĳɹ�"
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
            "id": "9828",
            "nid": "1fdd2f68d8fc883c",
            "name": "����",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": "",
            "createUserId": 31308,
            "createTime": "2020-04-20T20:25:30.243",
            "startTime": "2020-04-20T00:00:00",
            "endTime": "2020-04-21T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": true,
            "keyVisible": true,
            "autoSubmitOnTimeLimit": false,
            "drawPlotId": 2710,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": null,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": 0,
            "scoreAppear": 1,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "id": "6676",
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
            "id": "6678",
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
            "id": "6681",
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
            "id": "6682",
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
            "id": "6685",
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
            "id": "6687",
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
            "id": "6689",
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
            "id": "6691",
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
            "id": "6694",
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
        }
    ],
    "pagecount": 2,
    "recordcount": 13,
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

##### 4.��ȡ������ҵ��ʵ�飬��ϰ����

```http
http://localhost:5000/api/Course/HomeWork?authtoken=97F02636E249793A37CED81599713373CF32DF9495F10BDD397063C90385D876&id=9828
```

| ������    | ����   | �Ƿ�ɿ� | ˵��               |
| --------- | ------ | -------- | ------------------ |
| authtoken | string | ��       | ����               |
| id        | int    | ��       | ��ҵ��ʵ�飬��ϰid |

���أ�

| �ֶ�                    | ����          | ˵��                          |
| ----------------------- | ------------- | ----------------------------- |
| retcode                 | int           | ������                        |
| info                    | array[object] |                               |
| id                      | int           | id                            |
| name                    | string        | ����                          |
| mode                    | int           | ���ͣ�1���� 2��ϰ 3��ҵ 4ʵ�� |
| isOpen                  | bool          | �Ƿ��                      |
| timeLimit               | int           | ��ʱ���                      |
| retryTimes              | int           | ���Դ���                      |
| memo                    | string        | ˵��                          |
| createUserId            | int           | ������Id                      |
| createTime              | dateTime      | ����ʱ��                      |
| startTime               | dateTime      | ��ʼʱ��                      |
| endTime                 | dateTime      | ����ʱ��                      |
| forbiddenCopy           | bool          | ��ֹ������Ŀ                  |
| forbiddenMouseRightMenu | bool          | ��ֹ�Ҽ�                      |
| enableClientJudge       | bool          | ����ѧ�����ľ�                |
| keyVisible              | bool          | ѧ�����ľ���׼�𰸿ɼ�      |
| drawPlotId              | int           | ����Id                        |
| courseId                | int           | �γ�Id                        |
| enableMutualJudge       | bool          | ��ҵ����                      |
| mutualJudgeEndTime      | dateTime      | ������ֹʱ��                  |
| setScore                | double        | �ܷ�                          |
| viewOneWithAnswerKey    | bool          | ���ʱ��׼�𰸿ɼ�            |
| ord                     | int           | ����                          |
| scoreAppear             | int           | �ɼ�չʾ��1չʾ��2��չʾ      |
| delayEndTime            | dateTime      | ������ֹʱ��                  |
| delayPercentOfScore     | double        | �����÷ֱ���                  |
| ipallowAccessCheck      | bool          | IP��ַ���ʼ��                |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "id": "9828",
        "name": "����",
        "mode": 3,
        "isOpen": true,
        "timeLimit": 0,
        "retryTimes": 0,
        "memo": "",
        "createUserId": 31308,
        "createTime": "2020-04-20T20:25:30.243",
        "startTime": "2020-04-20T00:00:00",
        "endTime": "2020-04-21T23:59:00",
        "forbiddenCopy": true,
        "forbiddenMouseRightMenu": true,
        "enableClientJudge": true,
        "keyVisible": true,
        "drawPlotId": 2710,
        "courseId": 422,
        "enableMutualJudge": null,
        "mutualJudgeEndTime": null,
        "setScore": 100.0,
        "viewOneWithAnswerKey": false,
        "ord": 0,
        "scoreAppear": 1,
        "delayEndTime": null,
        "delayPercentOfScore": null,
        "ipallowAccessCheck": false
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



##### 5. �༭(����)

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

##### 6. ɾ��

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

#####  7. ����

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

##### 2.��ȡ������ӡ������Ϣ

```http
http://localhost:5000/api/Course/PaperTask?authtoken=97F02636E249793A37CED81599713373CF32DF9495F10BDD397063C90385D876&id=671
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵�� |
| --------- | ------ | -------- | ---- |
| authtoken | string | ��       | ���� |
| id        | int    | ��       | id   |

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
    "info": {
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



##### 3. ��ӡ������ѡ��

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

##### 4.��Ӵ�ӡ����

[post]

```http
http://localhost:5000/api/Course/AddPaperTask?courseId=422&authtoken=&testId=9828
```

| ������    | ����          | �Ƿ�ɿ� | ˵��               |
| --------- | ------------- | -------- | ------------------ |
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



##### 5. ������ӡ��δ����

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

##### 6. ɾ����ӡ

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



#### 7.�ֹ����

##### 1.�ֹ�����б�

```http
http://localhost:5000/api/DrawPlot/DrawPlotsList?authtoken=97F02636E249793A37CED81599713373CF32DF9495F10BDD397063C90385D876&createdUserId=31308
```

������

| ������        | ����   | �Ƿ�ɿ� | ˵��                       |
| ------------- | ------ | -------- | -------------------------- |
| authtoken     | string | ��       | ����                       |
| createdUserId | int    | ��       | ������id����ǰ��¼�û�id�� |

���أ�

| �ֶ�    | ����          | ˵��   |
| ------- | ------------- | ------ |
| retcode | int           | ������ |
| info    | array[object] |        |

```
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 2400,
            "labId": 282,
            "dptype": "TestPaper",
            "name": "����������ֹ����",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-17T13:55:25.327",
            "updateTime": "2019-04-17T13:55:25.327",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2409,
            "labId": 158,
            "dptype": "TestPaper",
            "name": "C�����ֹ����2",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-18T09:45:14.737",
            "updateTime": "2019-04-18T09:45:14.737",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2410,
            "labId": 420,
            "dptype": "TestPaper",
            "name": "C���Բ��Բ���",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-18T16:21:04.387",
            "updateTime": "2019-04-18T16:21:04.387",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2427,
            "labId": 306,
            "dptype": "TestPaper",
            "name": "test",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-24T14:14:08.317",
            "updateTime": "2019-04-24T14:14:08.317",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2458,
            "labId": 158,
            "dptype": "TestPaper",
            "name": "����A",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-29T16:07:39.827",
            "updateTime": "2019-04-29T16:07:39.827",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2459,
            "labId": 158,
            "dptype": "TestPaper",
            "name": "new",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-29T16:12:52.637",
            "updateTime": "2019-04-29T16:12:52.637",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2467,
            "labId": 420,
            "dptype": "TestPaper",
            "name": "1",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-05-06T12:24:57.143",
            "updateTime": "2019-05-06T12:24:57.143",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2570,
            "labId": 158,
            "dptype": "TestPaper",
            "name": "����0729",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-07-29T13:23:52.92",
            "updateTime": "2019-07-29T13:23:52.92",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
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

##### 2.�����б�

```http
http://localhost:5000/api/DrawPlot/TestPaperTopic?authtoken=&drawplotId=2570
```

������

| ������     | ����   | �Ƿ�ɿ� | ˵��       |
| ---------- | ------ | -------- | ---------- |
| authtoken  | string | ��       | ����       |
| drawplotId | int    | ��       | �ֹ����id |

���أ�

| ������    | ����   | ˵��   |
| --------- | ------ | ------ |
| retcode   | ������ |        |
| authtoken | string |        |
| info      | object |        |
| name      | string | ����   |
| topicId   | int    | ����Id |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "name": "�ж���",
            "topicId": 701
        },
        {
            "name": "ѡ����",
            "topicId": 702
        },
        {
            "name": "���������",
            "topicId": 703
        },
        {
            "name": "���������",
            "topicId": 704
        },
        {
            "name": "����Ĵ���",
            "topicId": 705
        },
        {
            "name": "���������",
            "topicId": 706
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

##### 3.��Ŀ�������ͣ��Ѷ�������

```http
http://localhost:5000/api/DrawPlot/QuestionList?authtoken=&labId=158&topicList=701&difficultyList=1&page=1&count=100
```

������

ע�⣺����topicList��difficultyList  ���Բ���ֵ��Ĭ�ϲ����У�һ�����ͣ��Ѷȣ���Ӧһ��Id�����Դ�һ��id���߶��id�������id�м�ʱ�á�������Ӣ�Ķ��ţ����������һ��id���治Ҫ�ӡ�����

���磺api/DrawPlot/QuestionList?labId=158&topicList=701��702&difficultyList=1��2��3��4,5&page=1&count=100

| ������         | ����   | �Ƿ�ɿ� | ˵��                                          |
| -------------- | ------ | -------- | --------------------------------------------- |
| authtoken      | string | ��       | ����                                          |
| labId          | int    | ��       | ����Id                                        |
| topicList      | string | ��       | ���ͣ����ϻ�ȡ����id��API��                   |
| difficultyList | string | ��       | �Ѷȣ�1���� 2���ϼ� 3���е� 4������ 5���� |
| page           | int    | ��       | ҳ��                                          |
| count          | int    | ��       | ����                                          |

���أ�

| ������            | ����     | ˵��               |
| ----------------- | -------- | ------------------ |
| retcode           | ������   |                    |
| authtoken         | string   |                    |
| info              | object   |                    |
| id                | int      | ��Ŀid             |
| topicId           | int      | ����id             |
| bundleRank        | int      | ���               |
| questionFace      | string   | ��Ŀ               |
| score             | double   | ����               |
| optionA           | string   | ѡ��A              |
| optionB           | string   | B                  |
| optionC           | string   | C                  |
| optionD           | string   | D                  |
| answerKey         | string   | ��               |
| answerKeyExt      | string   | ����               |
| defaultAnswer     | string   | Ĭ�ϴ�           |
| difficulty        | int      | �Ѷ�               |
| knowledge         | string   | ȫ��֪ʶ��         |
| ord               | int      | ����               |
| isDel             | bool     | �Ƿ�ɾ��           |
| maxTopKnowledgeId | int      | �������Ӽ���֪ʶ�� |
| pagecount         | int      | ��ҳ��             |
| recordcount       | int      | ������             |
| isfirst           | bool     | �Ƿ��ǵ�һҳ       |
| hasnext           | bool     | �Ƿ�����һҳ       |
| items             | object   | ��                 |
| debug             | string   | ����               |
| id                | int      | id                 |
| datetime          | datetime | ʱ��               |
| message           | string   | ������Ϣ           |

```json
{
    "retcode": 0,
    "authtoken": null,
     "info": [
        {
            "id": 43738,
            "labId": 158,
            "topicId": 701,
            "bundleRank": 1,
            "questionFace": "C���Թ涨�����ڳ��������û�ָ������һ��������Ϊ�����������򽫴Ӵ˿�ʼִ�С�",
            "score": 1.0,
            "optionA": "��ȷ",
            "optionB": "����",
            "optionC": "",
            "optionD": "",
            "answerKey": "B",
            "answerKeyExt": null,
            "defaultAnswer": null,
            "difficulty": 2,
            "knowledge": "6:",
            "ord": 1,
            "isDel": false,
            "maxTopKnowledgeId": 826
        },
        {
            "id": 43739,
            "labId": 158,
            "topicId": 701,
            "bundleRank": 1,
            "questionFace": "����ִ�е�Ч�������ݵĴ洢�ṹ��ء�",
            "score": 1.0,
            "optionA": "��ȷ",
            "optionB": "����",
            "optionC": "",
            "optionD": "",
            "answerKey": "A",
            "answerKeyExt": null,
            "defaultAnswer": null,
            "difficulty": 3,
            "knowledge": "6:",
            "ord": 2,
            "isDel": false,
            "maxTopKnowledgeId": 826
        },����
     ], 
    "pagecount": 7,
    "recordcount": 660,
    "isfirst": true,
    "hasnext": true,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}

```



 #### 8. ����

##### 1.��ȡ�û��յ����ż�

[get]����

```http 
http://localhost:5000/api/Message/GetReceiveMessage?authtoken=&userId=31308
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |      |
| --------- | ------ | -------- | ------ | ---- |
| authtoken | string | ��       | ����   |      |
| userId    | int    | ��       | �û�id |      |

����:

| ������      | ����   | �Ƿ�ɿ� | ��ע         |
| ----------- | ------ | -------- | ------------ |
| retcode     | ������ | ��       | ˵������     |
| authtoken   | string | ��       | �û���¼��ʶ |
| info        | object | ��       | �յ����ż�   |
| pagecount   | int    | ��       | ��ҳ����     |
| recordcount | int    | ��       | ����������   |
| isfirst     | bool   | ��       | �Ƿ��ǵ�һҳ |
| hasnext     | bool   | ��       | �Ƿ�����һҳ |
| items       | object | ��       |              |
| debug       | string | ��       | ������Ϣ     |
| id          | int    | ��       | id           |
| message     | string | ��       | ������Ϣ     |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 1342,
            "code": "1342",
            "sender": 29991,
            "subject": "����2",
            "body": "123",
            "isImportant": false,
            "sendTime": "2020-06-09T10:02:19.25",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 1110,
            "code": "1110",
            "sender": 29992,
            "subject": "������",
            "body": "�ط�",
            "isImportant": false,
            "sendTime": "2019-12-19T14:29:17.693",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 978,
            "code": "978",
            "sender": 20543,
            "subject": "��������",
            "body": "���������",
            "isImportant": true,
            "sendTime": "2019-09-24T10:23:56.147",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 966,
            "code": "966",
            "sender": 20543,
            "subject": "2",
            "body": "2",
            "isImportant": false,
            "sendTime": "2019-09-23T14:04:42.203",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 965,
            "code": "965",
            "sender": 20543,
            "subject": "1",
            "body": "1",
            "isImportant": false,
            "sendTime": "2019-09-23T14:04:30.977",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 962,
            "code": "962",
            "sender": 20543,
            "subject": "���������������ʾ�������1234567890",
            "body": "���ԣ����������������ʾ�������1234567890",
            "isImportant": true,
            "sendTime": "2019-09-20T15:12:27.367",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 960,
            "code": "960",
            "sender": 20543,
            "subject": "����",
            "body": "�������������������������������������������������������������������������������������������������������������������&nbsp;&nbsp;",
            "isImportant": true,
            "sendTime": "2019-09-20T10:56:18.293",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 881,
            "code": "881",
            "sender": 20543,
            "subject": "����",
            "body": "test",
            "isImportant": false,
            "sendTime": "2019-05-09T16:06:19.59",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 872,
            "code": "872",
            "sender": 20543,
            "subject": "����",
            "body": "new����",
            "isImportant": false,
            "sendTime": "2019-04-29T15:53:45.817",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 870,
            "code": "870",
            "sender": 20543,
            "subject": "222",
            "body": "����",
            "isImportant": false,
            "sendTime": "2019-04-29T09:34:32.56",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 869,
            "code": "869",
            "sender": 20543,
            "subject": "1111",
            "body": "test",
            "isImportant": false,
            "sendTime": "2019-04-28T16:45:45.34",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 867,
            "code": "867",
            "sender": 20543,
            "subject": "����",
            "body": "�ʼ�δ������",
            "isImportant": false,
            "sendTime": "2019-04-28T14:34:05.243",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 863,
            "code": "863",
            "sender": 20543,
            "subject": "1",
            "body": "1",
            "isImportant": true,
            "sendTime": "2019-04-25T09:11:00.997",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 861,
            "code": "861",
            "sender": 20543,
            "subject": "����",
            "body": "����",
            "isImportant": true,
            "sendTime": "2019-04-23T11:30:16.267",
            "isDel": false,
            "isRecycle": false
        }
    ],
    "pagecount": 2,
    "recordcount": 14,
    "isfirst": true,
    "hasnext": true,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2.��ȡ�û��������ż�

[get]����

```http 
http://localhost:5000/api/Message/GetSendMessage?authtoken=&userId=31308
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |      |
| --------- | ------ | -------- | ------ | ---- |
| authtoken | string | ��       | ����   |      |
| userId    | int    | ��       | �û�id |      |

����:

| ������      | ����   | �Ƿ�ɿ� | ��ע         |
| ----------- | ------ | -------- | ------------ |
| retcode     | ������ | ��       | ˵������     |
| authtoken   | string | ��       | �û���¼��ʶ |
| info        | object | ��       | �������ż�   |
| pagecount   | int    | ��       | ��ҳ����     |
| recordcount | int    | ��       | ����������   |
| isfirst     | bool   | ��       | �Ƿ��ǵ�һҳ |
| hasnext     | bool   | ��       | �Ƿ�����һҳ |
| items       | object | ��       |              |
| debug       | string | ��       | ������Ϣ     |
| id          | int    | ��       | id           |
| message     | string | ��       | ������Ϣ     |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 964,
            "code": "964",
            "sender": 31308,
            "subject": "12111",
            "body": "1111111111111111111111222222222",
            "isImportant": true,
            "sendTime": "2019-09-23T13:15:58.88",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 879,
            "code": "879",
            "sender": 31308,
            "subject": "����",
            "body": "1",
            "isImportant": false,
            "sendTime": "2019-05-05T15:51:18.187",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 871,
            "code": "871",
            "sender": 31308,
            "subject": "����",
            "body": "1111",
            "isImportant": false,
            "sendTime": "2019-04-29T15:50:37.007",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 865,
            "code": "865",
            "sender": 31308,
            "subject": "test",
            "body": "11111",
            "isImportant": false,
            "sendTime": "2019-04-26T09:44:40.14",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 862,
            "code": "862",
            "sender": 31308,
            "subject": "test",
            "body": "����",
            "isImportant": true,
            "sendTime": "2019-04-24T13:50:07.937",
            "isDel": false,
            "isRecycle": false
        }
    ],
    "pagecount": 1,
    "recordcount": 5,
    "isfirst": true,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

#####  3.��ȡ�û����ڻ���վ�е��յ��ż� 

[get]����

```http 
http://localhost:5000/api/Message/GetRecycleMessage?authtoken=&userId=31308
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |      |
| --------- | ------ | -------- | ------ | ---- |
| authtoken | string | ��       | ����   |      |
| userId    | int    | ��       | �û�id |      |

����:

| ������      | ����   | �Ƿ�ɿ� | ��ע           |
| ----------- | ------ | -------- | -------------- |
| retcode     | ������ | ��       | ˵������       |
| authtoken   | string | ��       | �û���¼��ʶ   |
| info        | object | ��       | ����վ�е��ż� |
| pagecount   | int    | ��       | ��ҳ����       |
| recordcount | int    | ��       | ����������     |
| isfirst     | bool   | ��       | �Ƿ��ǵ�һҳ   |
| hasnext     | bool   | ��       | �Ƿ�����һҳ   |
| items       | object | ��       |                |
| debug       | string | ��       | ������Ϣ       |
| id          | int    | ��       | id             |
| message     | string | ��       | ������Ϣ       |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 1341,
            "code": "1341",
            "sender": 29991,
            "subject": "����",
            "body": "����һ���ܷ���յ�",
            "isImportant": true,
            "sendTime": "2020-06-08T19:16:40.827",
            "isDel": false,
            "isRecycle": false
        }
    ],
    "pagecount": 1,
    "recordcount": 1,
    "isfirst": true,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

#####  4.��ȡ�ʼ�id��ȡMessage����Ϣ

[get]����

```http 
http://localhost:5000/api/Message/GetMessageById?authtoken=&id=1343
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| id        | int    | ��       | �ʼ�id |

����:

| ������      | ����   | �Ƿ�ɿ� | ��ע           |
| ----------- | ------ | -------- | -------------- |
| retcode     | ������ | ��       | ˵������       |
| authtoken   | string | ��       | �û���¼��ʶ   |
| info        | object | ��       | �ż��ľ�����Ϣ |
| pagecount   | int    | ��       | ��ҳ����       |
| recordcount | int    | ��       | ����������     |
| isfirst     | bool   | ��       | �Ƿ��ǵ�һҳ   |
| hasnext     | bool   | ��       | �Ƿ�����һҳ   |
| items       | object | ��       |                |
| debug       | string | ��       | ������Ϣ       |
| id          | int    | ��       | id             |
| message     | string | ��       | ������Ϣ       |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "id": 1343,
        "code": "1343",
        "sender": 25262,
        "subject": "����",
        "body": "������",
        "isImportant": false,
        "sendTime": "2020-06-09T16:30:50.24",
        "isDel": false,
        "isRecycle": false,
        "senderNavigation": null,
        "peMessageAttach": [],
        "peMessageReceive": []
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

#####  5.��ȡ�ʼ�id��ȡMessageReceive����Ϣ

[get]����

```http 
http://localhost:5000/api/Message/GetMessageReceiveById?authtoken=&Id=1343
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| id        | int    | ��       | �ʼ�id |

����:

| ������      | ����   | �Ƿ�ɿ� | ��ע              |
| ----------- | ------ | -------- | ----------------- |
| retcode     | ������ | ��       | ˵������          |
| authtoken   | string | ��       | �û���¼��ʶ      |
| info        | object | ��       | Receive�ľ�����Ϣ |
| pagecount   | int    | ��       | ��ҳ����          |
| recordcount | int    | ��       | ����������        |
| isfirst     | bool   | ��       | �Ƿ��ǵ�һҳ      |
| hasnext     | bool   | ��       | �Ƿ�����һҳ      |
| items       | object | ��       |                   |
| debug       | string | ��       | ������Ϣ          |
| id          | int    | ��       | id                |
| message     | string | ��       | ������Ϣ          |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "messageId": 1343,
        "receiver": 25263,
        "isReaded": true,
        "isDel": false,
        "isRecycle": false,
        "message": null,
        "receiverNavigation": null
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

#####  6.�����ʼ�id��MessageReceive�������վ

[get]����

```http 
http://localhost:5000/api/Message/DeleteMessagetoRecycle?authtoken=&id=1342
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| id        | int    | ��       | �ʼ�id |

����:

| ������      | ����   | �Ƿ�ɿ� | ��ע         |
| ----------- | ------ | -------- | ------------ |
| retcode     | ������ | ��       | ˵������     |
| authtoken   | string | ��       | �û���¼��ʶ |
| info        | object | ��       |              |
| pagecount   | int    | ��       | ��ҳ����     |
| recordcount | int    | ��       | ����������   |
| isfirst     | bool   | ��       | �Ƿ��ǵ�һҳ |
| hasnext     | bool   | ��       | �Ƿ�����һҳ |
| items       | object | ��       |              |
| debug       | string | ��       | ������Ϣ     |
| id          | int    | ��       | id           |
| message     | string | ��       | ������Ϣ     |

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
    "message": "�ʼ��ɹ��������վ"
}
```

#####  7.�����ʼ�id��MessageReceive������ɾ��

[get]����

```http 
http://localhost:5000/api/Message/DeleteMessagetoEnd?authtoken=&id=1342
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��   |
| --------- | ------ | -------- | ------ |
| authtoken | string | ��       | ����   |
| id        | int    | ��       | �ʼ�id |

����:

| ������      | ����   | �Ƿ�ɿ� | ��ע         |
| ----------- | ------ | -------- | ------------ |
| retcode     | ������ | ��       | ˵������     |
| authtoken   | string | ��       | �û���¼��ʶ |
| info        | object | ��       |              |
| pagecount   | int    | ��       | ��ҳ����     |
| recordcount | int    | ��       | ����������   |
| isfirst     | bool   | ��       | �Ƿ��ǵ�һҳ |
| hasnext     | bool   | ��       | �Ƿ�����һҳ |
| items       | object | ��       |              |
| debug       | string | ��       | ������Ϣ     |
| id          | int    | ��       | id           |
| message     | string | ��       | ������Ϣ     |

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
    "message": "�ʼ��ɹ�����ɾ��"
}
```

#####  8.�����ʼ�id��MessageReceive�ӻ���վ���ƻص��ռ�����       [get]����

```http 
http://localhost:5000/api/Message/MessageBackReceive?authtoken=&id=1342
```

#####  9.�����ʼ�id��Message��Ϊ��Ҫ�ļ�       [get]����

```http 
http://localhost:5000/api/Message/MessageImportant?authtoken=&id=1342
```

#####  10.�����ʼ�id��Message��Ϊ����Ҫ�ļ�       [get]����

```http 
http://localhost:5000/api/Message/MessageNoImportant?authtoken=&id=1342
```

##### 11.���PeMessage�ʼ�(��ӵ�ͬʱ�޸�code����Ӷ�Ӧ��receive��Ҳ����˵��get����NewCodeAndAddPeMessageReceive����)     ���������½������PeMessage���ݡ�

##### [post]

```http 
http://localhost:5000/api/Message/AddMessage?authtoken=
```

������   ���͸�ʽ��Body+raw+Json

```json
{
    "sender":31308, //������id
    "subject":"�����Ƿ����ݿ�洢",
    "body":"postman����",
    "isImportant":false
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
    "info": {
        "id": 1355,
        "code": "1",
        "sender": 31308,
        "subject": "�����Ƿ����ݿ�洢3",
        "body": "postman����3",
        "isImportant": false,
        "sendTime": "2020-06-12T20:27:03.9564602+08:00",
        "isDel": false,
        "isRecycle": false
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "����PeMessage�ʼ��ɹ�"
}
```

#####  12.���PeMessage�ʼ���code��Ϊ��idһ�� ���� �������Ӧ��PeMessageReceive������

[get]����

```http 
http://localhost:5000/api/Message/NewCodeAndAddPeMessageReceive?authtoken=&id=1351&userid=29991
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��                 |
| --------- | ------ | -------- | -------------------- |
| authtoken | string | ��       | ����                 |
| id        | int    | ��       | �ʼ�id��MessageId��  |
| userid    | int    | ��       | �ռ���id��Receiver�� |

����:

| ������      | ����   | �Ƿ�ɿ� | ��ע         |
| ----------- | ------ | -------- | ------------ |
| retcode     | ������ | ��       | ˵������     |
| authtoken   | string | ��       | �û���¼��ʶ |
| info        | object | ��       | ��           |
| pagecount   | int    | ��       | ��ҳ����     |
| recordcount | int    | ��       | ����������   |
| isfirst     | bool   | ��       | �Ƿ��ǵ�һҳ |
| hasnext     | bool   | ��       | �Ƿ�����һҳ |
| items       | object | ��       |              |
| debug       | string | ��       | ������Ϣ     |
| id          | int    | ��       | id           |
| message     | string | ��       | ������Ϣ     |

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
    "message": "���ʼ���code�Ѿ����ʼ�idһ��,�������Ӧ��PeMessageReceive�����ݽ���"
}
```

#####  13.�����ʼ�id���ʼ���Ϊ�Ѷ�       [get]����

```http 
http://localhost:5000/api/Message/MessageHasReaded?authtoken=&id=1351
```

#####  14.�����ʼ�id�����͵��ʼ���ɾ����PeMessage�е�isDel=1       [get]����

```http 
http://localhost:5000/api/Message/DeleteMessageHasSend?authtoken=&id=1351
```

#####  15.���ݹؼ��ֺͰ༶��ȡͨѶ¼�������û�������ʵ�������ؼ��ֵ� ����Ч�˻�����ʦ��ͬ����ˡ���

?     ����ؼ��ֺͰ༶���ǿյĻ���ֻ������������ʦ               

 [get]���� 

```http 
http://localhost:5000/api/Message/GetTongxunlu?authtoken=&keyword=��&property00=��16
```

������

| ������     | ����   | �Ƿ�ɿ� | ˵��         |
| ---------- | ------ | -------- | ------------ |
| authtoken  | string | ��       | ����         |
| keyword    | string | ��       | �����Ĺؼ��� |
| property00 | string | ��       | ���ڵİ༶   |

����:

| ������      | ����   | �Ƿ�ɿ� | ��ע         |
| ----------- | ------ | -------- | ------------ |
| retcode     | ������ | ��       | ˵������     |
| authtoken   | string | ��       | �û���¼��ʶ |
| info        | object | ��       | ����������   |
| pagecount   | int    | ��       | ��ҳ����     |
| recordcount | int    | ��       | ����������   |
| isfirst     | bool   | ��       | �Ƿ��ǵ�һҳ |
| hasnext     | bool   | ��       | �Ƿ�����һҳ |
| items       | object | ��       |              |
| debug       | string | ��       | ������Ϣ     |
| id          | int    | ��       | id           |
| message     | string | ��       | ������Ϣ     |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 23201,
            "userName": "hyf123",
            "userNO": null,
            "password": "E10ADC3949BA59ABBE56E057F20F883E",
            "realName": "�����",
            "sex": null,
            "brithday": "0001-01-01T00:00:00",
            "email": null,
            "mobile": null,
            "userIdentity00": null,
            "userIdentity01": "1",
            "userIdentity02": null,
            "userIdentity03": "2",
            "zip": null,
            "address": null,
            "avatar": null,
            "introduction": null,
            "property00": null,
            "property01": null,
            "property02": null,
            "property03": null,
            "property04": null,
            "property05": null,
            "property06": null,
            "property07": null,
            "property08": null,
            "property09": null,
            "schoolId": null,
            "school": null
        },
        {
            "id": 24783,
            "userName": "hangrui",
            "userNO": null,
            "password": "E10ADC3949BA59ABBE56E057F20F883E",
            "realName": "����",
            "sex": null,
            "brithday": "0001-01-01T00:00:00",
            "email": null,
            "mobile": null,
            "userIdentity00": null,
            "userIdentity01": "1",
            "userIdentity02": null,
            "userIdentity03": "2",
            "zip": null,
            "address": null,
            "avatar": null,
            "introduction": null,
            "property00": null,
            "property01": null,
            "property02": null,
            "property03": null,
            "property04": null,
            "property05": null,
            "property06": "CC6EA763B557E16CD7AFAC3DE40C560C2F524AF1A838C517",
            "property07": null,
            "property08": null,
            "property09": null,
            "schoolId": null,
            "school": null
        }
    ],
    "pagecount": 1,
    "recordcount": 2,
    "isfirst": true,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "��������п�����ʦ����Ϣ"
}
```

#####  16.���ݾ���PeMessage��id����Ҫ�ı��code��ֵ������Ӧ��PeMessage��codeֵ�ı�

[get]����

```http 
http://localhost:5000/api/Message/ChangeCode?authtoken=&id=1363&code=1362/1363
```

������

| ������    | ����   | �Ƿ�ɿ� | ˵��                |
| --------- | ------ | -------- | ------------------- |
| authtoken | string | ��       | ����                |
| id        | int    | ��       | �ʼ�id��MessageId�� |
| code      | int    | ��       | �ı���codeֵ      |