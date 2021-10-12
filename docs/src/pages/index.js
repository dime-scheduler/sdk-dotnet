import React from 'react';
import clsx from 'clsx';
import Layout from '@theme/Layout';
import Link from '@docusaurus/Link';
import useDocusaurusContext from '@docusaurus/useDocusaurusContext';
import useBaseUrl from '@docusaurus/useBaseUrl';
import styles from './styles.module.css';
import ImageCard from './imageCard';
import styled from "styled-components";

const features = [
  {
    title: 'Connect any system',
    imageUrl: 'img/integrate.svg',
    description: (
      <>
        Dime.Scheduler's flexibility allows for integration with any system. Connect your bespoke software and workflows with Dime.Scheduler and vice versa.
      </>
    ),
  },
  {
    title: 'Easy to use SDK',
    imageUrl: 'img/coder.svg',
    description: (
      <>
        The SDK is easy to use and it lets you plug your application right into the core of Dime.Scheduler.
      </>
    ),
  },
  {
    title: 'Open source',
    imageUrl: 'img/progress.svg',
    description: (
      <>
        The SDK is open source and is free to use. It was made by developers, for developers.
      </>
    ),
  },
];

function Feature({ imageUrl, title, description }) {
  const imgUrl = useBaseUrl(imageUrl);
  return (
    <div className={clsx('col col--4', styles.feature)}>
      {imgUrl && (
        <div className="text--center">
          <img className={styles.featureImage} src={imgUrl} alt={title} />
        </div>
      )}
      <h3>{title}</h3>
      <p>{description}</p>
    </div>
  );
}

function OtherFeature({ imageUrl, title, description, i }) {
  const imgUrl = useBaseUrl(imageUrl);

  const offsetCls = "col--offset-2";
  const isImageRight = i % 2 == 0;

  const txtCls = `col col--5 padding-vert--xl ${!isImageRight ? offsetCls : ""}`;
  const txt = <div className={txtCls}>
    <h2>{title}</h2>
    <p className="featureDescription_2nlI">{description}</p>
  </div>;

  const imgCls = `col col--5 ${isImageRight ? offsetCls : ""}`;
  const img = <div className={imgCls}>
    <div className="featureImageColumn_QmtA">
      <img alt={title} src={imgUrl} style={{ height: "250px" }} />
    </div>
  </div>;

  const content = i % 2 == 0 ? [img, txt] : [txt, img];
  return (
    <div className="row">{content}</div>
  );
}


const ImageContainer = styled.div`
  grid-template-columns: 1fr 1fr;
  @media (max-width: 900px) {
    grid-template-columns: 1fr;
    margin: 0 10px;
  }
`;

const Container = styled.div`
  display: flex;
  align-items: center;
  justify-content: center;
  @media (max-width: 900px) {
    margin-top: 30px;
  }
`;

const PurpleSection = styled.section`
  background: #6e62b5
`;


function Home() {
  const context = useDocusaurusContext();
  const { siteConfig = {} } = context;
  return (
    <Layout
      title={`${siteConfig.title}`}
      description="Description will go into a meta tag in <head />">
      <header className={clsx('hero hero--primary heroTilted_3die', styles.heroBanner)}>
        <div className="container">
          <h1 className="hero__title">{siteConfig.title}</h1>
          <p className="hero__subtitle">{siteConfig.tagline}</p>
          <div className={styles.buttons}>
            <Link
              className={clsx(
                'button button--outline button--secondary button--lg',
                styles.getStarted,
              )}
              to={useBaseUrl('docs/')}>
              Get Started
            </Link>
          </div>
        </div>
      </header>
      <main>

        {features && features.length > 0 && (
          <section className={styles.features}>
            <div className="container">
              <div className="row">
                {features.map((props, idx) => (
                  <OtherFeature key={idx} {...props} i={idx} />
                ))}
              </div>
            </div>
          </section>
        )}

        <PurpleSection className={styles.features}>
          <div className="container">
            <ImageContainer>
              <Container>
                <ImageCard image={"img/DS1.png"} height='500' width='800' />
              </Container>
            </ImageContainer>
          </div>
        </PurpleSection>


      </main>
    </Layout >
  );
}

export default Home;
