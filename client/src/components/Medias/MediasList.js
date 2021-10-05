import { useEffect, useState, useRef  } from 'react'
import './Medias.css'
import { useDispatch, useSelector } from 'react-redux'
import { getMedias } from '../../redux/actions/medias/medias'
import { RatingModal } from '../Ratings/RatingModal'
import { Media } from './Media'
import { Button } from '../../containers/Button/Button'

export const MediasList = ({mediaType}) => {
    const [showModal, setModalVisibility] = useState(false);
    const [id, setId] = useState("");
    const [ammount, setAmmount] = useState(10);

    const isInitialMount = useRef(true)
    const dispatch = useDispatch()
    const medias = useSelector(state => state.medias.medias)

    useEffect(() => {
        dispatch(getMedias("", 10, mediaType))
    }, [dispatch, mediaType])

    const handleShowMore = () => {
        setAmmount(ammount + 10);
    }

    useEffect(() => {
        if (isInitialMount.current) {
            isInitialMount.current = false
        } else {
            dispatch(getMedias("", ammount, mediaType))
        }
    }, [dispatch, ammount, mediaType])

    const handleShowRatingModal = () => {
        setModalVisibility(!showModal)
    }

    const clickStarAction = (id) => {
        setId(id)
        handleShowRatingModal()
    }

    const mediasRender = medias.map(media => {
        return (
            <div key={media.id}>
                <Media
                    media={media}
                    clickStar={clickStarAction}
                />
            </div>

        )
    })
    return (
        <div className="mediasContainer">
            <div className="mediasList">
                {mediasRender}
            </div>
            {
                medias.length < ammount ? "" :
                    <Button 
                        text="Show more"
                        clickAction={() => handleShowMore()}
                    />
            }
            <RatingModal
                mediaId={id}
                handleShowRatingModal={handleShowRatingModal}
                showRatingModal={showModal}
                mediaType={mediaType}
            />
        </div>
    )
}
