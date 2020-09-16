var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
import { HttpHelper } from "../Helpers/HttpHelper.js";
export class CommentRepository extends HttpHelper {
    constructor() {
        super();
        let self = this;
        self.baseUrl += "api/photo";
    }
    getAllPhotos() {
        return __awaiter(this, void 0, void 0, function* () {
            let self = this;
            const response = yield self.http(self.baseUrl + "/Get");
            return response.parsedBody;
        });
    }
    getAllPhotosForAlbum(photoId) {
        return __awaiter(this, void 0, void 0, function* () {
            let self = this;
            const response = yield self.http(self.baseUrl + "/GetAllCommentsForPhoto?photoId=" + photoId);
            return response.parsedBody;
        });
    }
}
//# sourceMappingURL=CommentRepository.js.map