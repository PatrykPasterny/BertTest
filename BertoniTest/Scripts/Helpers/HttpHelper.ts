export interface HttpResponse<T> extends Response {
    parsedBody?: T;
}

export class HttpHelper {
    public baseUrl: string;

    constructor() {
        let self = this;
        var getUrl = window.location;
        self.baseUrl = getUrl.protocol + "//" + getUrl.host + "/";
    }

    async http<T>(request: RequestInfo): Promise<HttpResponse<T>> {
        const response: HttpResponse<T> = await fetch(request);

        try {
            response.parsedBody = await response.json();
        } catch (ex) { }

        if (!response.ok) {
            throw new Error(response.statusText);
        }

        return response;
    }
}