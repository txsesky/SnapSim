﻿public class Capacitor: Device
{
    public override TypeEnum DeviceType
    {
        get { return TypeEnum.Capacitor; }
    }

    public DeviceNode PositiveNode;
    public DeviceNode NegativeNode;
    public double Resistance = 100;

    public override string ToString()
    { 
        return "C" + DeviceName + " " + PositiveNode + " " + NegativeNode + " " + Device.ConvertValueToString(Resistance) + "\n";
    }

    public void SetPositiveNode(Node positiveNode)
    {
        PositiveNode.ConnectedNode = positiveNode;
        positiveNode.AddDeviceNode(PositiveNode);
    }

    public void SetNegativeNode(Node negativeNode)
    {
        NegativeNode.ConnectedNode = negativeNode;
        negativeNode.AddDeviceNode(NegativeNode);
    }
}
