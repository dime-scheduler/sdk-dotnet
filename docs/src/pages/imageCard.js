import React, { useCallback } from 'react'
import { useSpring, animated } from 'react-spring'
import styled from "styled-components";

import './styles.css' // // Icons made by Freepik from www.flaticon.com

const Container = styled.div`
  width: ${props => props.width}px;
  height: ${props => props.height}px;
  cursor: ${props => props.isClickable ? "pointer" : "auto"};
`;

const AnimatedCard = styled(animated("img"))`
  border-radius: 5px;
  box-shadow: 0 10px 30px -5px rgba(0, 0, 0, 0.3);
  transition: box-shadow 0.5s;
  height: 100%;
  width: 100%;
  &:hover {
    box-shadow: 0 30px 100px -10px rgba(0, 0, 0, 0.4);
  }
`;

const ImageCard = (props) => {
    const { image, height = 500, width = 600, onClick, className, style } = props;

    const [spring, setSpring] = useSpring(() => ({
        xys: [0, 0, 1],
        config: { mass: 5, tension: 350, friction: 40 },
    }));

    const calculateRotation = useCallback((x, y, imageWidth, imageHeight) => [
        -(y - imageHeight / 2) / 100,
        (x - imageWidth / 2) / 100,
        1.01,
    ], []);

    return (
        <Container width={width} height={height} onClick={onClick} isClickable={!!onClick} className={className} style={style}>
            <AnimatedCard
                src={image}
                onMouseMove={({ clientX: x, clientY: y }) =>
                    setSpring({
                        xys: calculateRotation(x, y, width, height),
                    })
                }
                onMouseLeave={() =>
                    setSpring({
                        xys: [0, 0, 1],
                    })
                }
                style={{
                    transform: spring.xys.interpolate(
                        (x, y, s) => `perspective(600px) rotateX(${x}deg) rotateY(${y}deg) scale(${s})`
                    ),
                }}
            />

            {props.children}
        </Container>
    );
}

export default ImageCard;