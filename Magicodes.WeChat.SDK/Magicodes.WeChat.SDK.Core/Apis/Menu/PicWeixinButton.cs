﻿// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : PicWeixinButton.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 17:10
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using Newtonsoft.Json;

namespace Magicodes.WeChat.SDK.Apis.Menu
{
    /// <summary>
    ///     弹出微信相册发图器
    ///     用户点击按钮后，微信客户端将调起微信相册，完成选择操作后，将选择的相片发送给开发者的服务器，并推送事件给开发者，同时收起相册，随后可能会收到开发者下发的消息。
    /// </summary>
    public class PicWeixinButton : MenuButtonBase
    {
        public PicWeixinButton()
        {
            Type = MenuButtonTypes.pic_weixin;
        }

        /// <summary>
        ///     菜单KEY值，用于消息接口推送，不超过128字节
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.Always)]
        public new string Key { get; set; }
    }
}