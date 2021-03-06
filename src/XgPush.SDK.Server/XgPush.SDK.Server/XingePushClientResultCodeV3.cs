﻿namespace XgPush.SDK.Server
{
    /// <summary>
    /// (返回码) <see href="http://docs.developer.qq.com/xg/push_faq/server_api/rest_api_v3.html#%E9%94%99%E8%AF%AF%E7%A0%81" />
    /// </summary>
    public enum XingePushClientResultCodeV3
    {
        /// <summary>
        /// <see cref="F:XgPush.SDK.Server.XingePushClientResultCodeV3.调用成功" />
        /// </summary>
        调用成功 = 0,

        /// <summary>系统繁忙请稍后重试！</summary>
        系统繁忙_10100 = 10100, // 0x00002774

        /// <summary>系统繁忙请稍后重试！</summary>
        系统繁忙_10101 = 10101, // 0x00002775

        /// <summary>缺少参数请检查后重试</summary>
        缺少参数 = 10102, // 0x00002776

        /// <summary>参数值非法，请检查后重试</summary>
        参数值非法 = 10103, // 0x00002777

        /// <summary>鉴权未通过，请检查secret key！</summary>
        鉴权未通过 = 10104, // 0x00002778

        /// <summary>证书无效！</summary>
        证书无效 = 10105, // 0x00002779

        /// <summary>当前推送类型不支持多平台推送！</summary>
        当前推送类型不支持多平台推送 = 10106, // 0x0000277A

        /// <summary>消息体是非法Json格式</summary>
        消息体是非法Json格式 = 10107, // 0x0000277B

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10108 = 10108, // 0x0000277C

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10109 = 10109, // 0x0000277D

        /// <summary>设备未注册！</summary>
        设备未注册 = 10110, // 0x0000277E

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10111 = 10111, // 0x0000277F

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10112 = 10112, // 0x00002780

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10113 = 10113, // 0x00002781

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10114 = 10114, // 0x00002782

        /// <summary>帐号不能为空，帐号为空！</summary>
        帐号不能为空 = 10115, // 0x00002783

        /// <summary>帐号不存在</summary>
        帐号不存在 = 10116, // 0x00002784

        /// <summary>推送内容太大</summary>
        推送内容太大 = 10117, // 0x00002785

        /// <summary>创建推送任务失败，请稍后重试！</summary>
        创建推送任务失败_10201 = 10201, // 0x000027D9

        /// <summary>推送消息内容转换APNS失败</summary>
        推送消息内容转换APNS失败 = 10202, // 0x000027DA

        /// <summary>创建推送任务失败，请稍后重试！</summary>
        创建推送任务失败_10203 = 10203, // 0x000027DB

        /// <summary>推送失败，请稍后重试！</summary>
        推送失败 = 10204, // 0x000027DC

        /// <summary>推送任务过期，请检查！</summary>
        推送任务过期 = 10205, // 0x000027DD

        /// <summary>获取消息副本失败，请稍后重试！</summary>
        获取消息副本失败_10206 = 10206, // 0x000027DE

        /// <summary>获取消息副本失败，请稍后重试！</summary>
        获取消息副本失败_10207 = 10207, // 0x000027DF

        /// <summary>帐号列表推送失败，请稍后重试！</summary>
        帐号列表推送失败 = 10301, // 0x0000283D

        /// <summary>帐号列表推送部分失败！</summary>
        帐号列表推送部分失败 = 10302, // 0x0000283E

        /// <summary>帐号列表推送全部失败,请稍后重试！</summary>
        帐号列表推送全部失败 = 10303, // 0x0000283F

        /// <summary>token 列表推送部分失败！</summary>
        Token列表推送部分失败 = 10304, // 0x00002840

        /// <summary>token 列表推送全部失败,请稍后重试！</summary>
        Token列表推送全部失败 = 10305, // 0x00002841

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10401 = 10401, // 0x000028A1

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10402 = 10402, // 0x000028A2

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10403 = 10403, // 0x000028A3

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10404 = 10404, // 0x000028A4

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10405 = 10405, // 0x000028A5

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10406 = 10406, // 0x000028A6

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10407 = 10407, // 0x000028A7

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10501 = 10501, // 0x00002905

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10502 = 10502, // 0x00002906

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10503 = 10503, // 0x00002907

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10504 = 10504, // 0x00002908

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10505 = 10505, // 0x00002909

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10506 = 10506, // 0x0000290A

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10507 = 10507, // 0x0000290B

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10601 = 10601, // 0x00002969

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10602 = 10602, // 0x0000296A

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10603 = 10603, // 0x0000296B

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10604 = 10604, // 0x0000296C

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10605 = 10605, // 0x0000296D

        /// <summary>app 未注册，请注册后重试！</summary>
        App未注册 = 10606, // 0x0000296E

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10701 = 10701, // 0x000029CD

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10702 = 10702, // 0x000029CE

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10707 = 10707, // 0x000029D3

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10708 = 10708, // 0x000029D4

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10709 = 10709, // 0x000029D5

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10710 = 10710, // 0x000029D6

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10711 = 10711, // 0x000029D7

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10712 = 10712, // 0x000029D8

        /// <summary>内部错误，请稍候重试！</summary>
        内部错误_10713 = 10713, // 0x000029D9
    }
}