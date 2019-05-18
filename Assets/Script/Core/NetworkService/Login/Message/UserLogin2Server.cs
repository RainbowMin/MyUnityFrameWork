﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class UserLogin2Server
{
    /// <summary>
    /// 登录平台
    /// </summary>
    public LoginPlatform loginType;
    /// <summary>
    /// 该平台返回的key，如游客登录使用设备号
    /// </summary>
    public String typeKey;
    /// <summary>
    /// password
    /// </summary>
    public String pw;
    public RuntimePlatform platform;
    public String deviceUniqueIdentifier;
    public SystemLanguage deviceSystemLanguage = SystemLanguage.Unknown;
    /// <summary>
    /// 标记是否是重连
    /// </summary>
    public bool reloginState = false;

    public static UserLogin2Server GetLoginMessage(LoginPlatform loginType, String typeKey, String pw)
    {
        UserLogin2Server msg = new UserLogin2Server();
        msg.loginType = loginType;
        msg.typeKey = typeKey;
        msg.pw = pw;

        msg.deviceUniqueIdentifier = SystemInfo.deviceUniqueIdentifier;
        msg.platform = Application.platform;
        msg.deviceSystemLanguage = Application.systemLanguage;

        return msg;
    }
}

