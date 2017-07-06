import { DataReceived, ConnectionClosed } from "./Common"
import { TransportType, ITransport } from  "./Transports"
import { Mode } from "./Mode"

export interface IConnection {
    start(requestedMode: Mode): Promise<void>;
    send(data: any): Promise<void>;
    stop(): void;
    mode(): Mode

    onDataReceived: DataReceived;
    onClosed: ConnectionClosed;
}