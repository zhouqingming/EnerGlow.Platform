using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 操作模块
    /// </summary>
    public enum OperateModule
    {

        /// <summary>
        /// 个人账号
        /// </summary>
        [Description("个人账号")]
        Account = 0,

        /// <summary>
        /// 用户信息
        /// </summary>
        [Description("用户信息")]
        UserInfo = 1,

        /// <summary>
        /// 角色权限
        /// </summary>
        [Description("角色权限")]
        Role = 2,

        /// <summary>
        /// 菜单功能
        /// </summary>
        [Description("菜单功能")]
        Menu = 3,

        /// <summary>
        /// 测点信息
        /// </summary>
        [Description("测点信息")]
        DevPoint = 4,
        
        /// <summary>
        /// 设备类信息
        /// </summary>
        [Description("设备类信息")]
        DevClass =5,

        /// <summary>
        /// 厂家信息
        /// </summary>
        [Description("厂家信息")]
        DevProducer = 6,

        /// <summary>
        /// 元器件信息
        /// </summary>
        [Description("元器件信息")]
        ComponInfo = 7,


        /// <summary>
        /// 设备类型信息
        /// </summary>
        [Description("设备类型信息")]
        DevType = 8,

        /// <summary>
        /// 变压器信息
        /// </summary>
        [Description("变压器信息")]
        TransformerConfig = 9,

        /// <summary>
        /// 电房信息
        /// </summary>
        [Description("电房信息")]
        ElectricRoom =10,

        /// <summary>
        /// 设备信息
        /// </summary>
        [Description("设备信息")]
        DevList = 11,

        /// <summary>
        /// 能耗模型
        /// </summary>
        [Description("能耗模型")]
        EnergyConsuModel = 12,

        /// <summary>
        /// 能耗模型绑定
        /// </summary>
        [Description("能耗模型绑定")]
        StageDevRela = 13,

        /// <summary>
        /// 产品信息
        /// </summary>
        [Description("产品信息")]
        Product = 14,

        /// <summary>
        /// 产品工序关联
        /// </summary>
        [Description("产品工序关联")]
        ProductStageRela = 15,

        /// <summary>
        /// 工序关联
        /// </summary>
        [Description("工序关联")]
        Workstage = 16,

        /// <summary>
        /// 工序关联原材料信息
        /// </summary>
        [Description("工序关联原材料信息")]
        StageMaterRela = 17,

        /// <summary>
        ///原材料信息
        /// </summary>
        [Description("原材料信息")]
        Material = 18,

        /// <summary>
        /// 负荷类型
        /// </summary>
        [Description("负荷类型")]
        Load = 19,

        /// <summary>
        /// 能源种类信息
        /// </summary>
        [Description("能源种类信息")]
        EnergyKind = 20,

        /// <summary>
        /// 生产信息
        /// </summary>
        [Description("生产信息")]
        Productions = 21,

        /// <summary>
        /// 字典配置
        /// </summary>
        [Description("字典配置")]
        DictConfig = 22,

        /// <summary>
        /// 能源种类关联信息
        /// </summary>
        [Description("能源种类关联信息")]
        EnergyKindRela = 23,

        /// <summary>
        /// 项目菜单信息
        /// </summary>
        [Description("项目菜单信息")]
        ProjectMenu = 24,

        /// <summary>
        /// 项目菜单设备绑定信息
        /// </summary>
        [Description("项目菜单设备绑定信息")]
        ProjectMenuDevice = 25,

        /// <summary>
        /// 项目菜单设备绑定信息
        /// </summary>
        [Description("设备关联信息")]
        DevEnergyRela = 26,

        /// <summary>
        /// 报警子项信息
        /// </summary>
        [Description("报警子项信息")]
        DeviceItem = 27,

        /// <summary>
        /// 报警配置信息
        /// </summary>
        [Description("报警配置信息")]
        DeviceAlarmConfig = 28,

        /// <summary>
        /// 报警历史信息
        /// </summary>
        [Description("报警历史信息")]
        AlarmHistory = 29,

        /// <summary>
        /// 区域信息
        /// </summary>
        [Description("区域信息")]
        AreaInfo = 30,

        /// <summary>
        /// 设备联锁
        /// </summary>
        [Description("设备联锁")]
        DevInterlock = 31,

        /// <summary>
        /// 自定义月报表
        /// </summary>
        [Description("自定义月报表")]
        CustomMonthReport = 32,

        /// <summary>
        /// Rdb控制配置
        /// </summary>
        [Description("Rdb控制配置")]
        ConfigRdbCtrl = 33,
        /// <summary>
        ///项目设备类型关系
        /// </summary>
        [Description("项目设备类型关系")]
        ProjectDevTypeRela = 34,
        /// <summary>
        ///数据库
        /// </summary>
        [Description("数据库")]
        DataBaseInfo = 35,
        /// <summary>
        ///数据库
        /// </summary>
        [Description("配置项目")]
        ConfigProjectDiffer = 36,
        /// <summary>
        ///标签组
        /// </summary>
        [Description("标签组")]
        TagGroup = 37,
        /// <summary>
        ///配置报表标签
        /// </summary>
        [Description("配置报表标签")]
        ConfigReportTag = 38,

        /// <summary>
        ///分析服务配置
        /// </summary>
        [Description("分析服务配置")]
        ConfigAnalysisService = 39,

        /// <summary>
        ///中央空调系统设备属性配置
        /// </summary>
        [Description("中央空调系统设备属性配置")]
        VrvDevProperty = 40,

        /// <summary>
        /// 报警状态
        /// </summary>
        [Description("报警状态")]
        DevAlarmStatus = 41,

        /// <summary>
        /// 巡检/保养步骤
        /// </summary>
        [Description("巡检/保养步骤")]
        PatrolUpkeepStep = 42,

        /// <summary>
        /// 巡检/保养点
        /// </summary>
        [Description("巡检/保养步骤")]
        PatrolUpkeepSpot = 43,

        /// <summary>
        /// 巡检/保养计划
        /// </summary>
        [Description("巡检/保养计划")]
        PatrolUpkeepPlan = 44,

        /// <summary>
        /// 巡检/保养工单
        /// </summary>
        [Description("巡检/保养工单")]
        PatrolUpkeepOrder = 45,

        /// <summary>
        /// 应急/报警工单
        /// </summary>
        [Description("应急/报警工单")]
        AlarmEmergentOrder = 46,

        /// <summary>
        /// 管理层能耗配置 
        /// </summary>
        [Description("管理层能耗配置 ")]
        EnergyManagerment = 47,

        /// <summary>
        /// 备品库存管理
        /// </summary>
        [Description("备品库存管理")]
        Repertory = 48,

        /// <summary>
        /// 基础数据维护
        /// </summary>
        [Description("基础数据维护")]
        DataMaintain = 49,

        /// <summary>
        /// 资料文件信息
        /// </summary>
        [Description("资料文件信息")]
        DataFileInfo = 50,

        /// <summary>
        /// 电器设备信息
        /// </summary>
        [Description("电器设备信息")]
        EquipmentInfo = 51,

        /// <summary>
        /// 电器设备控制配置
        /// </summary>
        [Description("电器设备控制配置")]
        EquipmentCtrlMap = 52,

        /// <summary>
        /// 电器设备控制
        /// </summary>
        [Description("电器设备控制")]
        EquipmentCtrl = 53,

        /// <summary>
        /// 场景控制配置
        /// </summary>
        [Description("场景控制配置")]
        SceneCtrlMap = 54,

        /// <summary>
        /// 场景控制设置
        /// </summary>
        [Description("场景控制设置")]
        SceneCtrlSet = 55,

        /// <summary>
        /// 基础数据
        /// </summary>
        [Description("基础数据")]
        ConfigDictExpand = 56,

        /// <summary>
        /// 空调设备绑定
        /// </summary>
        [Description("空调设备绑定")]
        VrvDev = 57,

        /// <summary>
        /// 空调机房配置"
        /// </summary>
        [Description("空调机房配置")]
        VrvArea = 58,

        /// <summary>
        /// 能耗KPI计划值
        /// </summary>
        [Description("能耗KPI计划值")]
        KPIPlan =59,

        /// <summary>
        /// 月产能
        /// </summary>
        [Description("月产能")]
        ProductOutput =60,

        /// <summary>
        /// 班表产能
        /// </summary>
        [Description("班表产能")]
        Schedule =61,

        /// <summary>
        /// Rdb控制标签关联配置
        /// </summary>
        [Description("Rdb控制关联配置")]
        ConfigRdbCtrlRela = 62,

        /// <summary>
        /// 巡检/保养工单生成配置
        /// </summary>
        [Description("巡检/保养工单生成配置")]
        OrderGenerateConfig = 63,

        /// <summary>
        /// 电器信息
        /// </summary>
        [Description("电器信息")]
        Machine = 64,

        /// <summary>
        /// 能耗数据
        /// </summary>
        [Description("能耗数据")]
        StatisticsData = 65,

        /// <summary>
        /// 能耗模型
        /// </summary>
        [Description("能耗模型")]
        EnergyModel = 66,

        /// <summary>
        /// 设备资料
        /// </summary>
        [Description("设备资料")]
        DeviceData = 67,

        /// <summary>
        /// 自动控制时间表配置
        /// </summary>
        [Description("自动控制时间表配置")]
        AutoCtrlTimerMap = 68,

        /// <summary>
        /// 时间表触发配置
        /// </summary>
        [Description("时间表触发配置")]
        AutoCtrlTimerTrigger = 69,

        /// <summary>
        /// 区域场景
        /// </summary>
        [Description("区域场景")]
        AreaScene = 70,

        /// <summary>
        /// 自动控制时间表值设置
        /// </summary>
        [Description("自动控制时间表值设置")]
        AutoCtrlTimerValSet = 71,

        /// <summary>
        /// 日产能
        /// </summary>
        [Description("日产能")]
        ProductOutputDay = 72,

        /// <summary>
        /// 产线日产能
        /// </summary>
        [Description("产线日产能")]
        ProductOutputDayEnergy = 73,

        /// <summary>
        /// 产线月产能
        /// </summary>
        [Description("产线月产能")]
        ProductOutputEnergy = 74,

        /// <summary>
        /// 认证管理
        /// </summary>
        [Description("认证管理")]
        Identity = 75,

        /// <summary>
        /// 厂家信息(新)
        /// </summary>
        [Description("厂家信息(新)")]
        ProducerInfo = 76,

        /// <summary>
        /// 扩展字段
        /// </summary>
        [Description("扩展字段")]
        ExtField = 77,

        /// <summary>
        /// 元器件信息(新)
        /// </summary>
        [Description("元器件信息(新)")]
        ComponetInfo = 78,

        /// <summary>
        /// 电柜信息
        /// </summary>
        [Description("电柜信息")]
        CabinetInfo = 79,

        /// <summary>
        /// 电柜信息
        /// </summary>
        [Description("电力设备")]
        ElecDev = 80,

        /// <summary>
        /// 短信配置
        /// </summary>
        [Description("短信配置")]
        SmsConfig = 81,
    }
}
