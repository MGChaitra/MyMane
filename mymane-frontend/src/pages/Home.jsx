import React from 'react';
import Header from '../components/Header';
import HeroSection from '../components/HeroSection';
import PropertyAreaList from '../components/PropertyAreaList';
import FeaturedProperties from '../components/FeaturedProperties';
import CategoryList from '../components/CategoryList';
import RecentProperties from '../components/RecentProperties';
import Footer from '../components/Footer';

const Home = () => {
  return (
    <>
      <Header />
      <HeroSection />
      <PropertyAreaList />
      <FeaturedProperties />
      <CategoryList />
      <RecentProperties />
      <Footer />
    </>
  );
};

export default Home;
