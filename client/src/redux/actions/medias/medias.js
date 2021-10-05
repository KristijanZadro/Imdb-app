import * as actionsTypes from "../../actionsTypes"
import axios from "../../../axios"
import { useAppendUrl } from "../../../customHooks/useAppendUrl";

export const getMediasStart = () => {
    return {
        type: actionsTypes.GET_MEDIAS_START
    };
};
export const getMediasSuccess = (medias) => {
    return {
        type: actionsTypes.GET_MEDIAS_SUCCESS,
        medias
    };
};
export const getMediasFail = () => {
    return {
        type: actionsTypes.GET_MEDIAS_FAIL
    };
};

export const getMedias = (search = "", num = 10, mediaType) => {
    return async (dispatch) => {
        // send request
        dispatch(getMediasStart());
        search = encodeURIComponent(search);

        axios({
            method: "GET",
            url: "/medias",
            params: {
                search,
                num,
                mediaType
            }
        })
            .then((data) => {
                console.log("getMedias:", data);
                const medias = data.data.map(media => {
                    let coverImage = useAppendUrl(media.coverImage)
                    let releaseDate = media.releaseDate.split("T")[0]
                    let averageRating = Math.round(media.averageRating * 10) / 10
                    return { ...media, coverImage, releaseDate, averageRating }
                })
                dispatch(getMediasSuccess(medias));
            })
            .catch((e) => {
                console.error(e);
                dispatch(getMediasFail());
            });
    };
};

