import { useEffect, useRef, useState } from 'react'
import './SearchContainer.css'
import { AiOutlineSearch } from 'react-icons/ai'
import { useDispatch } from 'react-redux'
import _ from 'lodash'
import { Input } from '../Input/Input'

export const SearchContainer = ({ value, name, handleChange, searchAction, tabValue }) => {
    const [errorMsg, setErrorMsg] = useState()
    const dispatch = useDispatch()

    const isInitialMount = useRef(true)

    useEffect(() => {
        if (isInitialMount.current) {
            isInitialMount.current = false
        } else {
            if (!_.isEmpty(value) && value.trim().length >= 2) {
                setErrorMsg()
                const timer = setTimeout(() => {
                    dispatch(searchAction(value, 10, tabValue))
                }, 1000)
                return () => clearTimeout(timer);
            } else if (_.isEmpty(value)) {
                setErrorMsg()
                dispatch(searchAction(value, 10, tabValue))
            } else if (!value.trim()) {
                setErrorMsg("Search should not contain only empty space!")
            } else if (value.trim().length < 2) {
                setErrorMsg("Search must contain more than two characters!")
            }
        }
    }, [dispatch, value, searchAction, tabValue])

    return (
        <div className="searchContainer">
            <div className="searchBox">
                <div className="searchField">
                    <div
                        className="searchButton"
                        onClick={() => dispatch(searchAction(value, 10, tabValue))}
                    >
                        <AiOutlineSearch size={24} />
                    </div>
                    <Input
                        value={value}
                        name={name}
                        label="Search"
                        handleChange={handleChange}
                    />
                </div>
                <div className="errorMsg">
                    <p>{errorMsg}</p>
                </div>
            </div>
        </div>
    )
}
