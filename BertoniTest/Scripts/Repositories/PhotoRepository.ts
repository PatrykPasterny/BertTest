import { HttpHelper } from "../Helpers/HttpHelper.js";
import { Photo } from "../Models/Photo.js";

export class PhotoRepository extends HttpHelper {

    constructor() {
        super();
        let self = this;
        self.baseUrl += "api/photo"
    }

    async getAllPhotos(): Promise<Photo[]> {
        let self = this;

        const response = await self.http<Photo[]>(self.baseUrl + "/Get");
        return response.parsedBody;
    }

    async getAllPhotosForAlbum(albumId: number): Promise<Photo[]> {
        let self = this;

        const response = await self.http<Photo[]>(self.baseUrl + "/GetAllPhotosForAlbum?albumId=" + albumId);
        return response.parsedBody;
    }
}