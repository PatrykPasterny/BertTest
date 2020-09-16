var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
export class HttpHelper {
    constructor() {
        let self = this;
        var getUrl = window.location;
        self.baseUrl = getUrl.protocol + "//" + getUrl.host + "/";
    }
    http(request) {
        return __awaiter(this, void 0, void 0, function* () {
            const response = yield fetch(request);
            try {
                response.parsedBody = yield response.json();
            }
            catch (ex) { }
            if (!response.ok) {
                throw new Error(response.statusText);
            }
            return response;
        });
    }
}
//# sourceMappingURL=HttpHelper.js.map